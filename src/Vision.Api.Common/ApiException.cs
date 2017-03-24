using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    public class ApiException : Exception
    {
        private string errorCode;
        private string errorMsg;

        public ApiException()
            : base()
        {
        }

        public ApiException(string message)
            : base(message)
        {
        }

        protected ApiException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public ApiException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public ApiException(string errorCode, string errorMsg)
            : base(errorCode + ":" + errorMsg)
        {
            this.errorCode = errorCode;
            this.errorMsg = errorMsg;
        }

        public string ErrorCode
        {
            get { return this.errorCode; }
        }

        public string ErrorMsg
        {
            get { return this.errorMsg; }
        }
    }
}
