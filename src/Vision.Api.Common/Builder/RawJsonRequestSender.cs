using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common.Builder
{
    public class RawJsonRequestSender : RequestSender
    {
        #region Ctor
        public RawJsonRequestSender()
            : base(RequestContentTypes.ApplicationJsonUtf8, HttpMethods.POST, HttpMethods.PUT, HttpMethods.DELETE)
        {
        }
        #endregion

        #region Implement RequestSender
        protected override void ConfigureWebRequest(HttpWebRequest request, object requestData, HttpMethods method, IDictionary<string, string> headers = null)
        {
            base.ConfigureWebRequest(request, requestData, method, headers);

            var postData = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(requestData));
            var reqStream = request.GetRequestStream();
            reqStream.Write(postData, 0, postData.Length);
            reqStream.Close();
        }
        #endregion
    }
}
