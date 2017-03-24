using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    public class XmlApiClient : ApiClient
    {
        #region Ctor
        public XmlApiClient(string serverUrl, string appKey, string appSecret)
            : base(serverUrl, appKey, appSecret, FORMAT_XML)
        {
        }
        #endregion

        #region GetDefaultParser
        protected override IApiParser GetDefaultParser()
        {
            return DefaultXmlParser;
        }
        #endregion
    }
}
