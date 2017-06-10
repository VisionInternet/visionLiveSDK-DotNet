using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    public class ApiRequestParametersResolverAttribute : Attribute
    {
        #region Ctor
        public ApiRequestParametersResolverAttribute(Type resolverType)
        {
            ResolverType = resolverType;
        }
        #endregion

        #region Properties
        public Type ResolverType { get; private set; }
        #endregion
    }
}
