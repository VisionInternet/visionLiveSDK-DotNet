using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    /// <summary>
    /// the class to indicate it's a API parameter. Used in ApiRequest class;
    /// if no name, it will use the property name as parameter key.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class ApiRequestParameterAttribute : Attribute
    {
        #region Ctor
        public ApiRequestParameterAttribute(bool required = true)
        {
            Required = required;
        }
        #endregion

        #region Properties
        /// <summary>
        /// get or set the parameter whether is required or optioanl
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        /// get or set the display name of the API Request Parameter
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// get or set the description of the Api Request Parameter
        /// </summary>
        public string Description { get; set; }
        #endregion
    }
}
