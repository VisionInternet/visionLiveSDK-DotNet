using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Vision.Api.Common
{
    public static class WebUtils
    {
        public const string ACCEPT_XML = "application/xml";
        public const string ACCEPT_JSON = "application/json";

        public static readonly string ApiUserAgent = "Vision API Client";

        public static string DoPost(string url, IDictionary<string, string> parameters, string accept = ACCEPT_XML)
        {
            return DoPost(url, parameters, accept, default(CookieContainer));
        }

        public static string DoPost(string url, IDictionary<string, string> parameters, string accept, CookieContainer cookieContainer)
        {
            var req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.KeepAlive = true;
            req.UserAgent = ApiUserAgent;
            req.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
            req.Accept = string.IsNullOrEmpty(accept) ? ACCEPT_XML : accept;
            if (cookieContainer != null)
            {
                req.CookieContainer = cookieContainer;
            }

            var postData = Encoding.UTF8.GetBytes(BuildPostData(parameters));
            var reqStream = req.GetRequestStream();
            reqStream.Write(postData, 0, postData.Length);
            reqStream.Close();

            var rsp = (HttpWebResponse)req.GetResponse();
            var encoding = Encoding.GetEncoding(string.IsNullOrEmpty(rsp.CharacterSet) ? "utf-8" : rsp.CharacterSet);

            return GetResponseAsString(rsp, encoding);
        }

        public static string DoGet(string url, IDictionary<string, string> parameters, string accept = ACCEPT_XML)
        {
            return DoGet(url, parameters, accept, allowCookie: false);
        }

        public static string DoGet(string url, IDictionary<string, string> parameters, string accept, bool allowCookie = false)
        {
            var cookieContainer = default(CookieContainer);
            if (allowCookie)
            {
                cookieContainer = GetCookie(url);
            }
            return DoGet(url, parameters, accept, cookieContainer);
        }
        public static string DoGet(string url, IDictionary<string, string> parameters, string accept, CookieContainer cookieContainer)
        {
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

            var req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";
            req.KeepAlive = true;
            req.UserAgent = ApiUserAgent;
            req.ContentType = "application/x-www-form-urlencoded;charset=utf-8";

            req.AllowAutoRedirect = true;
            if (cookieContainer!=null)
            {
                req.CookieContainer = cookieContainer;
            }
            req.Accept = string.IsNullOrEmpty(accept) ? ACCEPT_XML : accept;

            var rsp = (HttpWebResponse)req.GetResponse();
            var encoding = Encoding.GetEncoding(string.IsNullOrEmpty(rsp.CharacterSet) ? "utf-8" : rsp.CharacterSet);
            return GetResponseAsString(rsp, encoding);
        }

        public static CookieContainer GetCookie(string url)
        {
            var cookies = new System.Net.CookieContainer();
            var req = WebRequest.Create(url) as HttpWebRequest;
            req.AllowAutoRedirect = true;
            req.CookieContainer = cookies;
            var res = req.GetResponse() as HttpWebResponse;
            //req.Abort();
            return cookies;
        }

        private static string GetResponseAsString(HttpWebResponse rsp, Encoding encoding)
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

        private static string BuildPostData(IDictionary<string, string> parameters)
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
    }
}
