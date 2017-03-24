using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    /// <summary>
    /// The Abstract Class of API Request
    /// </summary>
    public abstract class ApiRequest
    {
        private static readonly ConcurrentDictionary<string, Dictionary<string, PropertyInfo>> _RequestParameterPropertyMapping = new ConcurrentDictionary<string, Dictionary<string, PropertyInfo>>();

        #region GetParameters
        /// <summary>
        /// Get the Application Level Parameters
        /// </summary>
        /// <returns></returns>
        public virtual IDictionary<string, string> GetParameters()
        {
            #region Old Logic
            //var thisType = this.GetType();

            //var apiDictionary = new ApiDictionary();

            //var allPropertyInfos = thisType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.SetProperty);

            //var parameterProperties = default(Dictionary<string, PropertyInfo>);
            //if (!_RequestParameterPropertyMapping.TryGetValue(thisType.FullName, out parameterProperties) || parameterProperties == null)
            //{
            //    parameterProperties = new Dictionary<string, PropertyInfo>();
            //    foreach (var property in allPropertyInfos)
            //    {
            //        var apiParameterAttribtue = property.GetCustomAttribute<ApiRequestParameterAttribute>();
            //        if (apiParameterAttribtue != null)
            //        {
            //            var parameterKey = property.Name;
            //            parameterProperties.Add(parameterKey, property);
            //        }
            //    }
            //    _RequestParameterPropertyMapping.AddOrUpdate(thisType.FullName, parameterProperties, (key, value) => value);
            //}

            //// ToDo, need refine this logic
            //// Would better use deep iteration. 
            //// Support List, two level properties.
            //foreach (var key in parameterProperties.Keys)
            //{
            //    var valueSetSuccess = false;
            //    var propertyType = parameterProperties[key].PropertyType;
            //    var propertyValue = parameterProperties[key].GetValue(this);
            //    if (propertyType.IsGenericType)
            //    {
            //        var genericParameters = propertyType.GetGenericArguments();
            //        if (genericParameters.Length == 1 && typeof(IEnumerable<>).MakeGenericType(genericParameters[0]).IsAssignableFrom(propertyType))
            //        {
            //            var apiRequestParameterSubProperties = genericParameters[0].GetProperties(BindingFlags.Instance | BindingFlags.Public)
            //                                                                       .Where(c => c.GetCustomAttribute<ApiRequestParameterAttribute>() != null)
            //                                                                       .ToList();
            //            var isGenericParameterComplexType = apiRequestParameterSubProperties.Any();
            //            var index = 0;
            //            foreach (var item in propertyValue as IEnumerable)
            //            {
            //                if (item != null)
            //                {
            //                    if (!isGenericParameterComplexType)
            //                    {
            //                        apiDictionary.Add(string.Format("{0}[{1}]", key, index++), item);
            //                    }
            //                    else
            //                    {
            //                        var parentKey = string.Format("{0}[{1}]", key, index++);
            //                        foreach (var subProperty in apiRequestParameterSubProperties)
            //                        {
            //                            apiDictionary.Add(string.Format("{0}.{1}", parentKey, subProperty.Name), subProperty.GetValue(item));
            //                        }
            //                    }
            //                }
            //            }
            //            valueSetSuccess = true;
            //        }
            //    }
            //    if (!valueSetSuccess)
            //    {
            //        apiDictionary.Add(key, parameterProperties[key].GetValue(this));
            //    }
            //}

            //return apiDictionary;
            #endregion

            return GetParametersInternal(string.Empty, this);
        }
        #endregion

        internal static IDictionary<string, string> GetParametersInternal(string prefix, object model)
        {
            var apiDictionary = new ApiDictionary();

            if (model != null)
            {
                prefix = prefix ?? string.Empty;
                var thisType = model.GetType();

                var allPropertyInfos = thisType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.SetProperty);

                var parameterProperties = default(Dictionary<string, PropertyInfo>);
                if (!_RequestParameterPropertyMapping.TryGetValue(thisType.FullName, out parameterProperties) || parameterProperties == null)
                {
                    parameterProperties = new Dictionary<string, PropertyInfo>();
                    foreach (var property in allPropertyInfos)
                    {
                        var apiParameterAttribtue = property.GetCustomAttribute<ApiRequestParameterAttribute>();
                        if (apiParameterAttribtue != null)
                        {
                            var parameterKey = property.Name;
                            parameterProperties.Add(parameterKey, property);
                        }
                    }
                    _RequestParameterPropertyMapping.AddOrUpdate(thisType.FullName, parameterProperties, (key, value) => parameterProperties);
                }

                // primative types and string...
                if (!parameterProperties.Any())
                {
                    apiDictionary.Add(prefix, model);
                }
                // complex types & enumerable<T>
                else
                {
                    // ToDo, need refine this logic
                    // Would better use deep iteration. 
                    // Support List, two level properties.
                    foreach (var key in parameterProperties.Keys)
                    {
                        var valueSetSuccess = false;
                        var propertyType = parameterProperties[key].PropertyType;
                        var propertyValue = parameterProperties[key].GetValue(model);
                        if (propertyType.IsGenericType)
                        {
                            var genericParameters = propertyType.GetGenericArguments();
                            if (genericParameters.Length == 1 && typeof(IEnumerable<>).MakeGenericType(genericParameters[0]).IsAssignableFrom(propertyType))
                            {
                                var apiRequestParameterSubProperties = genericParameters[0].GetProperties(BindingFlags.Instance | BindingFlags.Public)
                                                                                           .Where(c => c.GetCustomAttribute<ApiRequestParameterAttribute>() != null)
                                                                                           .ToList();
                                var isGenericParameterComplexType = apiRequestParameterSubProperties.Any();
                                var index = 0;
                                foreach (var item in propertyValue as IEnumerable)
                                {
                                    var subPrefix = string.Format("{0}{1}{2}[{3}]", prefix, string.IsNullOrEmpty(prefix) ? string.Empty : ".", key, index++);
                                    var subDictionary = GetParametersInternal(subPrefix, item);
                                    apiDictionary.Merge(subDictionary);
                                }
                                valueSetSuccess = true;
                            }
                        }
                        if (!valueSetSuccess)
                        {
                            var subPrefix = string.Format("{0}{1}{2}", prefix, string.IsNullOrEmpty(prefix) ? string.Empty : ".", key);
                            var subDictionary = GetParametersInternal(subPrefix, parameterProperties[key].GetValue(model));
                            apiDictionary.Merge(subDictionary);
                        }
                    }
                }
            }
            return apiDictionary;
        }
    }
}
