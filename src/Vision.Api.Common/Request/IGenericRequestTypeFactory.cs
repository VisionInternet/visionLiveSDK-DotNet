using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common.Request
{
    public interface IGenericRequestTypeFactory
    {
        Type CreateRequestType(Type baseType, IDictionary<string, object> dependentProperties);
    }
}
