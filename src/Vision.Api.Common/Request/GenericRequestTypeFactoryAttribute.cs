using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common.Request
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class GenericRequestTypeFactoryAttribute : Attribute
    {
        #region Ctor
        public GenericRequestTypeFactoryAttribute(Type factoryType)
        {
            if (!typeof(IGenericRequestTypeFactory).IsAssignableFrom(factoryType) || !factoryType.IsClass)
                throw new ArgumentException("factoryType should be a class and implement IGenericRequestTypeFactory.");
            FactoryType = factoryType;
        }
        #endregion

        #region Properties
        public Type FactoryType { get; private set; }
        #endregion
    }
}
