using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Vision.Api.Common.Parser
{
    public class JSONApiParser : IApiParser
    {
        #region ReadOnly
        private static readonly ConcurrentDictionary<string, JavaScriptSerializer> _Parsers = new ConcurrentDictionary<string, JavaScriptSerializer>();
        #endregion

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
            var javascriptSerializer = default(JavaScriptSerializer);
            if (!_Parsers.TryGetValue(typeof(TResponse).FullName, out javascriptSerializer) || javascriptSerializer == null)
            {
                javascriptSerializer = new JavaScriptSerializer();
                _Parsers.AddOrUpdate(typeof(TResponse).FullName, javascriptSerializer, (key, value) => javascriptSerializer);
            }

            var response = javascriptSerializer.Deserialize<TResponse>(body);
            if (response != null)
                response.ResponseBody = body;
            return response;
        }
        #endregion
    }
}
