using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    public static class RequestContentTypes
    {
        /// <summary>
        /// For .NET Core: FromFormAttribute, FromQueryAttribute, or default binding
        /// </summary>
        public const string XWWWFormUrlEncodedUtf8 = "application/x-www-form-urlencoded;charset=utf-8";
        /// <summary>
        /// .NET Core: FromBodyAttribute
        /// </summary>
        public const string ApplicationJsonUtf8 = "application/json;charset=utf-8"; 
    }
}
