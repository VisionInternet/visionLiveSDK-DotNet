using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision.Api.Common.Builder;
using Vision.Api.Common.Parser;

namespace Vision.Api.Common
{
    public abstract class ApiClientBase : IApiClient
    {
        #region Ctor
        public ApiClientBase(string serverUrl, string format)
        {
            ServerURL = serverUrl;
            Format = format;
            ReportServerURLError = false;
            RequestSenderFactory = new RequestSenderFactory();
        }
        #endregion


        #region Static ReadOnly
        protected static readonly IApiParser DefaultXmlParser = new XmlApiParser();
        protected static readonly IApiParser DefaultJsonParser = new JSONApiParser();
        protected static readonly IApiParser DefaultNewtonApiParser = new NewtonApiParser();
        #endregion

        #region Const
        public const string FORMAT_XML = "xml";
        public const string FORMAT_JSON = "json";
        public const string API_VERSION = "1.0";
        #endregion

        #region Properties
        public string ServerURL { get; protected set; }
        public string Format { get; protected set; }
        public bool ReportServerURLError { get; set; }
        public IRequestSenderFactory RequestSenderFactory { get; protected set; }
        #endregion

        #region GetDefaultParser
        protected virtual IApiParser GetDefaultParser()
        {
            return FORMAT_JSON.Equals(Format) ? (IApiParser)DefaultJsonParser : (IApiParser)DefaultXmlParser;
        }
        #endregion

        #region Execute
        /// <summary>
        /// Execute the request, and parse the response with parser.
        /// </summary>
        /// <typeparam name="TRequest"></typeparam>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="request">the request of the API</param>
        /// <param name="parser">if it's NULL, will get parser according to the Format of ApiClient.</param>
        /// <returns></returns>
        public virtual TResponse Execute<TRequest, TResponse>(TRequest request, IApiParser parser = null)
            where TRequest : ApiRequest
            where TResponse : ApiResponse<TRequest>, new()
        {
            parser = parser ?? GetDefaultParser();
            if (parser == null)
                throw new ApiException("Sorry, can't get the correct parser from parameter and request.");
            var responseBody = default(string);
            try
            {
                var accept = Format == FORMAT_JSON ? "application/json" : "application/xml";

                responseBody = DoExecuteInternal(request, accept);
                return parser.Parse<TResponse>(responseBody);
            }
            catch (Exception e)
            {
                if (ReportServerURLError)
                {
                    return new TResponse
                    {
                        ResponseBody = responseBody,
                        ErrorCode = ApiErrorCode.SERVERURL_ERROR,
                        ErrorMessage = "sorry, your API Server URL might be wrong."
                    };
                }
                else
                    throw e;
            }
        }

        public virtual async Task<TResponse> ExecuteAsync<TRequest, TResponse>(TRequest request, IApiParser parser = null)
            where TRequest : ApiRequest
            where TResponse : ApiResponse<TRequest>, new()
        {
            return await Task.FromResult(Execute<TRequest, TResponse>(request, parser));
        }
        #endregion

        #region Virtual Methods
        protected virtual string BuildApiUrl(IApiRequestInfo requestInfo)
        {
            return ServerURL;
        }

        protected virtual string DoExecuteInternal<TRequest>(TRequest request, string accept)
            where TRequest : ApiRequest
        {
            var apiRequestInfo = ApiUtils.GetApiRequestInfo<TRequest>();
            var apiUrl = BuildApiUrl(apiRequestInfo);

            var httpHeaders = BuildHttpHeaders(request);
            var requestSender = RequestSenderFactory.GetRequestSender(apiRequestInfo.Method, apiRequestInfo.ContentType);
            if (requestSender is IParameterRequestSender)
            {
                var parameters = BuildParameters(request);
                return requestSender.Send(apiUrl, parameters, accept, apiRequestInfo.Method, httpHeaders);
            }
            else
            {
                return requestSender.Send(apiUrl, request, accept, apiRequestInfo.Method, httpHeaders);
            }
        }

        protected virtual IDictionary<string, string> BuildHttpHeaders<TRequest>(TRequest request)
            where TRequest : ApiRequest
        {
            return new Dictionary<string, string>();
        }

        protected virtual IDictionary<string, string> BuildParameters<TRequest>(TRequest request)
            where TRequest : ApiRequest
        {
            var allParameters = new ApiDictionary(request.GetParameters());
            allParameters.Add(ApiConstant.PARAM_VERSION_KEY, API_VERSION);
            allParameters.Add(ApiConstant.PARAM_TIMESTAMP_KEY, DateTime.UtcNow);
            return allParameters;
        }
        #endregion
    }
}
