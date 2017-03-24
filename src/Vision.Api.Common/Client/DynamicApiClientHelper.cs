using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    public static class DynamicApiClientHelper
    {
        #region ExecuteDynamic
        /// <summary>
        /// Execute API call with dynamic input and result.
        /// </summary>
        /// <param name="parameters">IDictionary(string,string) or dynamic object</param>
        /// <returns></returns>
        public static dynamic ExecuteDynamic(string url, object parameters)
        {
            try
            {
                var allParameters = default(IDictionary<string, string>);
                if (parameters is IDictionary<string, string>)
                {
                    allParameters = parameters as IDictionary<string, string>;
                }
                else
                {
                    allParameters = new Dictionary<string, string>();
                    foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(parameters))
                    {
                        var obj = propertyDescriptor.GetValue(parameters);
                        allParameters.Add(propertyDescriptor.Name, (obj ?? "").ToString());
                    }
                }
                var responseBody = WebUtils.DoPost(url, allParameters, "application/json");
                return JsonConvert.DeserializeObject(responseBody);
            }
            catch (Exception e)
            {
                return new
                {
                    ErrorCode = ApiErrorCode.SERVERURL_ERROR,
                    ErrorMessage = "sorry, your API Server URL might be wrong:" + e.Message
                };
            }
        }
        #endregion
    }
}
