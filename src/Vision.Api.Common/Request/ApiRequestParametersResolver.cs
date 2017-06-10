using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common.Request
{
    public class ApiRequestParametersResolver : IApiRequestParametersResolver
    {
        #region Implement IApiRequestParametersProvider
        /// <summary>
        /// Get Parameters Types
        /// </summary>
        /// <param name="apiRequestType"></param>
        /// <returns></returns>
        public Dictionary<string, Type> GetParametersInfo(Type apiRequestType)
        {
            var result = new Dictionary<string, Type>();
            if (typeof(ApiRequest).IsAssignableFrom(apiRequestType))
            {
                if (apiRequestType.IsSubclassOf(typeof(ApiRequest)))
                {
                    var allPropertyInfos = apiRequestType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty); // No need set;
                    foreach (var property in allPropertyInfos)
                    {
                        var apiParameterAttribtue = property.GetCustomAttribute<ApiRequestParameterAttribute>();
                        if (apiParameterAttribtue != null)
                        {
                            var parameterKey = property.Name;
                            result.Add(parameterKey, property.PropertyType);
                        }
                    }
                }
            }
            return result;            
        }

        /// <summary>
        /// Get Available Generic Types if apiRequestType is generic type.
        /// </summary>
        /// <param name="apiRequestType"></param>
        /// <returns></returns>
        public IEnumerable<Type> GetAvailableGenericTypes(Type apiRequestType)
        {
            return Enumerable.Empty<Type>();
        }
        #endregion
    }
}
