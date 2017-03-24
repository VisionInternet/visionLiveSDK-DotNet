using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common.Builder
{
    /// <summary>
    /// request  IDictionary<string, string>
    /// </summary>
    public class QueryStringRequestSender : RequestSender, IParameterRequestSender
    {
        #region Ctor
        public QueryStringRequestSender()
            : base(RequestContentTypes.XWWWFormUrlEncodedUtf8, HttpMethods.GET)
        {
        }
        #endregion

        #region Implement  
        protected override WebRequest BuildWebRequest(string url, object requestData, string accept, HttpMethods method, IDictionary<string, string> headers = null)
        {
            var parameters = requestData as IDictionary<string, string>;
            if (parameters != null && parameters.Count > 0)
            {
                if (url.Contains("?"))
                {
                    url = url + "&" + BuildPostData(parameters);
                }
                else
                {
                    url = url + "?" + BuildPostData(parameters);
                }
            }
            return base.BuildWebRequest(url, requestData, accept, method, headers);
        }
        #endregion
    }
}
