using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ApiDataStructureAttribute : Attribute
    {
        #region Ctor
        public ApiDataStructureAttribute(string displayName = null)
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

        public string Category { get; set; }
        #endregion
    }
}
