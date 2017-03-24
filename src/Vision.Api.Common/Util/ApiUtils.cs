using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    public static class ApiUtils
    {
        private static readonly ConcurrentDictionary<Type, string> _ApiNameMapping = new ConcurrentDictionary<Type, string>();
        private static readonly ConcurrentDictionary<Type, IApiRequestInfo> _ApiRequestAttributeMapping = new ConcurrentDictionary<Type, IApiRequestInfo>();

        public static string SignApiRequest(IDictionary<string, string> parameters, string appSecret)
        {
            // Step 1: order by the parameters
            var sortedParams = new SortedDictionary<string, string>(parameters);
            var dem = sortedParams.GetEnumerator();

            // Step 2: contact all parameter name and parameter value.
            var query = new StringBuilder(appSecret);
            while (dem.MoveNext())
            {
                var key = dem.Current.Key;
                var value = dem.Current.Value;
                if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
                {
                    query.Append(key).Append(value);
                }
            }

            // Step 3: encrypted with MD5
            var md5 = MD5.Create();
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(query.ToString()));

            // Step 4: convert the binary to uppercase hexadecimal
            var result = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                string hex = bytes[i].ToString("X");
                if (hex.Length == 1)
                {
                    result.Append("0");
                }
                result.Append(hex);
            }

            return result.ToString();
        }

        public static string GetApiName<TApiRequest>()
            where TApiRequest : ApiRequest
        {
            return GetApiName(typeof(TApiRequest));
        }

        public static string GetApiName(Type apiRequestType)
        {
            if (apiRequestType != null && apiRequestType.IsClass && typeof(ApiRequest).IsAssignableFrom(apiRequestType))
            {
                var apiName = default(string);
                if (_ApiNameMapping.TryGetValue(apiRequestType, out apiName))
                    return apiName;

                var apiNameAttribute = apiRequestType.GetCustomAttributes(typeof(ApiNameAttribute), false).Cast<ApiNameAttribute>().FirstOrDefault();
                apiName = apiNameAttribute != null ? apiNameAttribute.ApiName : null;
                if (!string.IsNullOrEmpty(apiName))
                    _ApiNameMapping.AddOrUpdate(apiRequestType, apiName, (key, value) => apiName);
                return apiName;
            }
            return null;
        }

        public static string ConcatForParam<T>(IEnumerable<T> objs)
        {
            var stringBuilder = new StringBuilder();
            foreach (var obj in objs)
            {
                if (stringBuilder.Length > 0)
                    stringBuilder.Append(ApiConstant.ArrayConcatChar);
                stringBuilder.Append(obj);
            }
            return stringBuilder.ToString();
        }

        public static IEnumerable<T> ConvertTo<T>(string str)
        {
            var items = new List<T>();
            if (!string.IsNullOrEmpty(str))
            {
                var array = str.Split(ApiConstant.ArrayConcatChar.ToArray(), StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in array)
                {
                    try
                    {
                        var obj = (T)Convert.ChangeType(item, typeof(T));
                        items.Add(obj);
                    }
                    catch { }
                }
            }
            return items;
        }

        public static IApiRequestInfo GetApiRequestInfo(Type apiRequestType)
        {
            if (apiRequestType != null && apiRequestType.IsClass)
            {
                var apiRequestAttribute = default(IApiRequestInfo);
                if (_ApiRequestAttributeMapping.TryGetValue(apiRequestType, out apiRequestAttribute))
                    return apiRequestAttribute;

               apiRequestAttribute = apiRequestType.GetCustomAttributes(typeof(ApiRequestAttribute), false).Cast<ApiRequestAttribute>().FirstOrDefault();
               if (apiRequestAttribute != null)
               {
                   _ApiRequestAttributeMapping.AddOrUpdate(apiRequestType, apiRequestAttribute, (key, value) => apiRequestAttribute);
                   return apiRequestAttribute;
               }
               var apiNameAttribute = apiRequestType.GetCustomAttributes(typeof(ApiNameAttribute), false).Cast<ApiNameAttribute>().FirstOrDefault();
               if (apiNameAttribute != null)
               {
                   var apiRequestIfo = new ApiRequestInfo()
                   {
                       Method = apiNameAttribute.Method,
                       ContentType = apiNameAttribute.ContentType
                   };
                   _ApiRequestAttributeMapping.AddOrUpdate(apiRequestType, apiRequestIfo, (key, value) => apiRequestIfo);
                   return apiRequestIfo;
               }
            }
            return null;
        }

        public static IApiRequestInfo GetApiRequestInfo<TRequest>()
        {
            return GetApiRequestInfo(typeof(TRequest));
        }

        internal class ApiRequestInfo : IApiRequestInfo
        {
            public string Url { get; set; }

            public HttpMethods Method { get; set; }

            public string ContentType { get; set; }
        }
    }
}
