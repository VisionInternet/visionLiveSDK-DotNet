using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    public static class ApiErrorCode
    {
        public const string INTERNAL_ERROR = "905";
        public const string SERVERURL_ERROR = "904";
        public const string APPCODE_NOTMATCH = "903";
        public const string PARAMETER = "902";
        public const string NOTFOUND = "901";
        public const string NOTAUTHORIZED = "900";

        public const string APIURLWRONG = "404";
        public const string MISSINGMETHOD = "100";
    }
}
