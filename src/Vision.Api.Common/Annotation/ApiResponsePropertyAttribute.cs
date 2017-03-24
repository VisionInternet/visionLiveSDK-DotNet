using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    /// <summary>
    /// The Attribute is used to indicate the property is the one for Api Response.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class ApiResponsePropertyAttribute : Attribute
    {
        #region Ctor
        public ApiResponsePropertyAttribute(string displayName = null)
        {
            DisplayName = displayName;
        }
        #endregion

        #region Properties
        /// <summary>
        /// get or set the display name of the Api Response Property
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// get or set the description of the Api Response Property
        /// </summary>
        public string Description { get; set; }
        #endregion
    }
}
