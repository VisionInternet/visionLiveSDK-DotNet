using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    /// <summary>
    /// declare API request
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class ApiRequestAttribute : Attribute, IApiRequestInfo
    {
        #region Ctor
        /// <summary>
        /// declare API Request with URL and method and contenttype.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="method"></param>
        /// <param name="contentType"></param>
        public ApiRequestAttribute(string url, HttpMethods method, string contentType)
        {
            Url = url;
            Method = method;
            ContentType = contentType;
        }
        /// <summary>
        /// declare API Request with URL and method;
        /// If method is HttpMethods.GET, ContentType default value is RequestContentTypes.XWWWFormUrlEncodedUtf8; otherwise, it's RequestContentTypes.ApplicationJsonUtf8
        /// </summary>
        /// <param name="url"></param>
        /// <param name="method"></param>
        public ApiRequestAttribute(string url, HttpMethods method)
            : this(url, method, method == HttpMethods.GET ? RequestContentTypes.XWWWFormUrlEncodedUtf8 : RequestContentTypes.ApplicationJsonUtf8)
        {
            Url = url;
            Method = method;
            ContentType = RequestContentTypes.ApplicationJsonUtf8;
        }
        /// <summary>
        /// declare API Request with URL. By default: Method -> HttpMethods.Post, ContentType -> RequestContentTypes.ApplicationJsonUtf8
        /// </summary>
        /// <param name="url"></param>
        public ApiRequestAttribute(string url)
            : this(url, HttpMethods.POST, RequestContentTypes.ApplicationJsonUtf8)
        {
        }
        #endregion

        #region Property
        /// <summary>
        /// API relative Url
        /// </summary>
        public string Url { get; private set; }
        /// <summary>
        /// API Http Method, by default,it's POST
        /// </summary>
        public HttpMethods Method { get; set; }
        /// <summary>
        /// API Request Content Type, by default, it's application/json;charset=utf-8
        /// </summary>
        public string ContentType { get; set; }
        #endregion
    }
}
