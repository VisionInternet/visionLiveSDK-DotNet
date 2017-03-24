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
    public class ApiClient : ApiClientBase
    {

        #region Ctor
        public ApiClient(string serverUrl, string appKey, string appSecret)
            : this(serverUrl, appKey, appSecret, FORMAT_XML)
        {
        }

        public ApiClient(string serverUrl, string appKey, string appSecret, string format)
            :base(serverUrl,format)
        {
            AppKey = appKey;
            AppSecret = appSecret;
        }
        #endregion

        #region Properties
        public string AppKey { get; private set; }
        public string AppSecret { get; private set; }
        #endregion

        #region Override
        protected override IDictionary<string, string> BuildParameters<TRequest>(TRequest request)
        {
            var allParameters = new ApiDictionary(request.GetParameters());
            allParameters.Add(ApiConstant.PARAM_METHOD_KEY, ApiUtils.GetApiName(request.GetType()));
            allParameters.Add(ApiConstant.PARAM_VERSION_KEY, API_VERSION);
            allParameters.Add(ApiConstant.PARAM_APP_KEY_KEY, AppKey);
            allParameters.Add(ApiConstant.PARAM_FORMAT_KEY, Format);
            allParameters.Add(ApiConstant.PARAM_TIMESTAMP_KEY, DateTime.UtcNow);

            allParameters.Add(ApiConstant.PARAM_SIGN_KEY, ApiUtils.SignApiRequest(allParameters, AppSecret));
            return allParameters;
        }
        #endregion
    }
}
