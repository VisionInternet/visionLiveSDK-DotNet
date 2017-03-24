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
    /// can be used for regular form-data, and x-www-form-urlencoded.
    /// </summary>
    public class FormDataRequestSender : RequestSender, IParameterRequestSender
    {
        #region Ctor
        public FormDataRequestSender()
            : base(RequestContentTypes.XWWWFormUrlEncodedUtf8, HttpMethods.POST, HttpMethods.PUT, HttpMethods.DELETE)
        {
        }
        #endregion

        #region Implement BuildWebRequest
        protected override void ConfigureWebRequest(HttpWebRequest request, object requestData, HttpMethods method, IDictionary<string, string> headers = null)
        {
            base.ConfigureWebRequest(request, requestData, method, headers);

            var parameters = requestData as IDictionary<string, string>;
            var postData = Encoding.UTF8.GetBytes(BuildPostData(parameters));
            var reqStream = request.GetRequestStream();
            reqStream.Write(postData, 0, postData.Length);
            reqStream.Close();
        }
        #endregion
    }
}
