using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common.Builder
{
    public abstract class RequestSender : IRequestSender
    {
        #region Static
        public const string ACCEPT_XML = WebUtils.ACCEPT_XML;
        public const string ACCEPT_JSON = WebUtils.ACCEPT_JSON;

        public static readonly string ApiUserAgent = WebUtils.ApiUserAgent;
        #endregion

        #region Ctor
        public RequestSender(string requestContentType, params HttpMethods[] supportedMethods)
        {
            RequestContentType = requestContentType;
            SupportedMethods = supportedMethods;
            DefaultUserAgent = ApiUserAgent;
            DefaultAccept = ACCEPT_JSON;
        }
        #endregion

        #region Implement IRequestSender
        protected string DefaultUserAgent { get;  set; }
        protected string DefaultAccept { get;  set; }
        public virtual HttpMethods[] SupportedMethods { get; protected set; }
        public virtual string RequestContentType { get; protected set; }
        public virtual string Send(string url, object requestData, string accept, HttpMethods method, IDictionary<string, string> headers = null)
        {
            if (!SupportedMethods.Contains(method))
                return string.Empty;

            var req = BuildWebRequest(url, requestData, accept, method, headers);

            var rsp = (HttpWebResponse)req.GetResponse();
            var encoding = Encoding.GetEncoding(string.IsNullOrEmpty(rsp.CharacterSet) ? "utf-8" : rsp.CharacterSet);
            return GetResponseAsString(rsp, encoding);
        }
        #endregion

        #region virtual BuildWebRequest & ConfigureWebRequest
        protected virtual void ConfigureWebRequest(HttpWebRequest request, object requestData, HttpMethods method, IDictionary<string, string> headers = null)
        {
        }

        protected virtual WebRequest BuildWebRequest(string url, object requestData, string accept, HttpMethods method, IDictionary<string, string> headers = null)
        {
            var req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = method.ToString();
            req.KeepAlive = true;
            req.UserAgent = DefaultUserAgent;
            req.ContentType = RequestContentType;
            req.Accept = string.IsNullOrEmpty(accept) ? DefaultAccept : accept;
            
            if (headers != null)
            {
                foreach (var key in headers.Keys)
                {                    
                    req.Headers[key] = headers[key];
                }
            }

            ConfigureWebRequest(req, requestData, method, headers);

            return req;
        }
        #endregion

        #region helper methods
        protected string GetResponseAsString(HttpWebResponse rsp, Encoding encoding)
        {
            StringBuilder result = new StringBuilder();
            Stream stream = null;
            StreamReader reader = null;

            try
            {
                stream = rsp.GetResponseStream();
                reader = new StreamReader(stream, encoding);

                char[] buffer = new char[256];
                int readBytes = 0;
                while ((readBytes = reader.Read(buffer, 0, buffer.Length)) > 0)
                {
                    result.Append(buffer, 0, readBytes);
                }
            }
            finally
            {
                if (reader != null) reader.Close();
                if (stream != null) stream.Close();
                if (rsp != null) rsp.Close();
            }

            return result.ToString();
        }

        protected string BuildPostData(IDictionary<string, string> parameters)
        {
            StringBuilder postData = new StringBuilder();
            bool hasParam = false;

            IEnumerator<KeyValuePair<string, string>> dem = parameters.GetEnumerator();
            while (dem.MoveNext())
            {
                string name = dem.Current.Key;
                string value = dem.Current.Value;
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(value))
                {
                    if (hasParam)
                    {
                        postData.Append("&");
                    }

                    postData.Append(name);
                    postData.Append("=");
                    postData.Append(Uri.EscapeDataString(value));
                    hasParam = true;
                }
            }

            return postData.ToString();
        }
        #endregion
    }
}
