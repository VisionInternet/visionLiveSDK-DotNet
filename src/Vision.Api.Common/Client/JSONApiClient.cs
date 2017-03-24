using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    public class JSONApiClient : ApiClient
    {
        #region Ctor
        public JSONApiClient(string serverUrl, string appKey, string appSecret)
            : base(serverUrl, appKey, appSecret, FORMAT_JSON)
        {
        }
        #endregion

        #region GetDefaultParser
        protected override IApiParser GetDefaultParser()
        {
            return DefaultJsonParser;
        }
        #endregion
    }
}
