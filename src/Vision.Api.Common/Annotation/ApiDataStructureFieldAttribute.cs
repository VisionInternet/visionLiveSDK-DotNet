using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class ApiDataStructureFieldAttribute : Attribute
    {
        #region Ctor
        public ApiDataStructureFieldAttribute(string displayName = null)
        {
            DisplayName = displayName;
        }
        #endregion

        #region Properties
        /// <summary>
        /// get or set display name
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// get or set description
        /// </summary>
        public string Description { get; set; }
        #endregion
    }
}
