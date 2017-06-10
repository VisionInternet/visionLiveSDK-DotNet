using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common.Request
{
    public interface IApiRequestParametersResolver
    {
        /// <summary>
        /// Get Parameters Information
        /// </summary>
        /// <param name="apiRequestType"></param>
        /// <returns></returns>
        Dictionary<string, Type> GetParametersInfo(Type apiRequestType);

        /// <summary>
        /// Get Available Generic Types if apiRequestType is generic type.
        /// </summary>
        /// <param name="apiRequestType"></param>
        /// <returns></returns>
        IEnumerable<Type> GetAvailableGenericTypes(Type apiRequestType);
    }
}
