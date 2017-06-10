using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common.Request
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public class GenericRequestTypePropertyDependencyAttribute : Attribute
    {
        #region Ctor
        public GenericRequestTypePropertyDependencyAttribute(params string[] properties)
        {
            Properties = properties;
        }
        #endregion

        #region Properties
        public string[] Properties { get; private set; }
        #endregion
    }
}
