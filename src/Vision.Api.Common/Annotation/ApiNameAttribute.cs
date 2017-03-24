using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    /// <summary>
    /// This class is to indicate the Api Name, which is usually used on IApiRequest class.
    /// Suggested API name format: vision.{app name}.{module}.{category}.{action}
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class ApiNameAttribute : Attribute
    {
        #region Ctor
        /// <summary>
        /// Create ApiName with Api Sub Name. The Full Api Name format suggested: vision.{app name}.{module}.{category}.{action}
        /// </summary>
        /// <param name="apiSubName">Api Sub Name without default prefix. Suggested format: {app name}.{module}.{category}.{action}</param>
        public ApiNameAttribute(string apiSubName)
        {
            ApiSubName = apiSubName;
            ApiName = string.Format("{0}.{1}", ApiConstant.API_NAME_PREFIX, ApiSubName);
            Method = HttpMethods.POST;
            ContentType = RequestContentTypes.XWWWFormUrlEncodedUtf8;
        }
        #endregion

        #region Property
        /// <summary>
        /// get the ApiSubName. without default prefix: "vision."
        /// </summary>
        protected string ApiSubName { get; private set; }

        /// <summary>
        /// Get the ApiName, with Default Prefix: "vision."
        /// </summary>
        public string ApiName { get; private set; }

        /// <summary>
        /// get or set the Display Name of the API
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// get or set the Category of the API.
        /// If it's NULL or Empty, we will use the default API Category in that Assembly.
        /// If there is no default API Category in the Assembly, we will use System Category
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// get or set the description of the Api Name.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// API Http Method, by default,it's POST
        /// </summary>
        public HttpMethods Method { get; set; }
        /// <summary>
        /// API Request Content Type, by default, it's application/x-www-form-urlencoded;charset=utf-8
        /// </summary>
        public string ContentType { get; set; }
        #endregion
    }
}
