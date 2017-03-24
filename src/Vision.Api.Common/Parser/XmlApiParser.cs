using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vision.Api.Common.Parser
{
    public class XmlApiParser : IApiParser
    {
        #region ReadOnly
        private static readonly ConcurrentDictionary<string, XmlSerializer> _Parsers = new ConcurrentDictionary<string, XmlSerializer>();
        #endregion

        #region Parse
        /// <summary>
        /// Use XmlSerializer to parse the body.
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="body"></param>
        /// <returns></returns>
        public TResponse Parse<TResponse>(string body) 
            where TResponse : class, IApiResponse
        {
            var xmlSerializer = default(XmlSerializer);
            if (!_Parsers.TryGetValue(typeof(TResponse).FullName, out xmlSerializer) || xmlSerializer == null)
            {
                var extraTypesAttribute = typeof(TResponse).GetCustomAttributes(typeof(XmlSerializerExtraTypesAttribute), false).Cast<XmlSerializerExtraTypesAttribute>().FirstOrDefault();
                var extraTypes = extraTypesAttribute != null ? extraTypesAttribute.Types : new Type[0];

                xmlSerializer = new XmlSerializer(typeof(TResponse), null, extraTypes, null, ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE);

                _Parsers.AddOrUpdate(typeof(TResponse).FullName, xmlSerializer, (key, value) => xmlSerializer);
            }

            var response = default(TResponse);
            using (var stringReader = new StringReader(body))
            {
                response = xmlSerializer.Deserialize(stringReader) as TResponse;
                if (response != null)
                    response.ResponseBody = body;
            }
            return response;        
        }
        #endregion
    }
}
