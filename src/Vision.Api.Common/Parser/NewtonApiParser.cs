using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common.Parser
{
    public class NewtonApiParser : IApiParser
    {
        #region Parse
        /// <summary>
        /// Use JavaScriptSerializer to parse the body.
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="body"></param>
        /// <returns></returns>
        public TResponse Parse<TResponse>(string body)
            where TResponse : class, IApiResponse
        { 
            var response = JsonConvert.DeserializeObject<TResponse>(body);
            if (response != null)
                response.ResponseBody = body;
            return response;
        }
        #endregion
    }
}
