using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision.Api.Common.Request;

namespace Vision.Cms.Mvc.Api.Domain
{
    public class ContentGenericRequestTypeFactory : IGenericRequestTypeFactory
    {
        #region Implement IGenericRequestTypeFactory
        public Type CreateRequestType(Type baseType, IDictionary<string, object> dependentProperties)
        {
            if (baseType.IsGenericType)
            {
                var contentApiName = dependentProperties[ApiContentConstants.ContentTypeNamePropertyName] as string;
                var contentApiType = ContentAPINameManager.GetContentApiType(contentApiName);
                return baseType.MakeGenericType(contentApiType);
            }
            return baseType;
        }
        #endregion
    }
}
