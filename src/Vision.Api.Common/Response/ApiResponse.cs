using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace Vision.Api.Common
{
    public interface IApiResponse
    { 
        string ErrorCode { get; set; }
        
        string ErrorMessage { get; set; }

        string ResponseBody { get; set; }
    }

    [XmlRoot(Namespace = ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE)]
    public abstract class ApiResponse<TRequest> : IApiResponse
        where TRequest : ApiRequest
    {
        /// <summary>
        /// Get or Set the Error Code. Refer to the constants ApiErrorCode;
        /// If no error, the ErrorCode shall be NULL or Empty
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }
        /// <summary>
        /// Get or Set the Error Message;
        /// If no error, the ErrorMessage shall be NULL or Empty
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Get or set the Response Body, which won't be serialized in JSON and XML.
        /// </summary>
        [XmlIgnore]
        [ScriptIgnore]
        public string ResponseBody { get; set; }
    }

    [XmlRoot(Namespace = ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE)]
    public abstract class ApiResponseWithResult<TRequest> : ApiResponse<TRequest> 
        where TRequest : ApiRequest
    {
        /// <summary>
        /// Get or set result of the request.
        /// </summary>
        [XmlElement("result")]
        [ApiResponseProperty]
        public bool Result { get; set; }
    }
}
