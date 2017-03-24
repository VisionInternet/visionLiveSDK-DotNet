using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision.Api.Common.Document;

namespace Vision.Api.Common
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
    public class ApiDocumentProviderAttribute : Attribute
    {
        #region Ctor
        public ApiDocumentProviderAttribute(Type apiDocumentProviderType)
        {
            if (!typeof(IApiDocumentProvider).IsAssignableFrom(apiDocumentProviderType))
                throw new ArgumentOutOfRangeException("apiDocumentProviderType should be implemented IApiDocumentationProvider interface.");

            ApiDocumentProviderType = apiDocumentProviderType;
        }
        #endregion

        #region Properties
        public Type ApiDocumentProviderType { get; private set; }
        #endregion
    }
}
