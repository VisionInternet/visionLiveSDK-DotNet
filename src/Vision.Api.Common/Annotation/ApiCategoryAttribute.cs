using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public class ApiCategoryAttribute : Attribute
    {
        #region Ctor
        public ApiCategoryAttribute(string name, string displayName = null, bool isDefault = false)
        {
            Name = name;
            DisplayName = displayName ?? Name;
            IsDefault = isDefault;
        }
        #endregion

        #region Properties
        /// <summary>
        /// get or set the unique name of the Api Category
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// get or set the display name of the Api Category;
        /// If it's NULL or Empty, will return the unique name.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// get or set whether this is the default Api Category in the assembly.
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// get or set the description of the Api Category
        /// </summary>
        public string Description { get; set; }
        #endregion
    }
}
