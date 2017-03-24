using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vision.Api.Common
{

    public interface IApiModelResponse : IApiResponse
    {
        List<ApiModelError> ModelErrors { get; set; }
    }

    /// <summary>
    /// The Abstract Class of API Model Response. Used to Model Validation
    /// </summary>
    [XmlRoot(Namespace = ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE)]
    public abstract class ApiModelResponse<TRequest> : ApiResponse<TRequest>, IApiModelResponse
        where TRequest : ApiRequest
    {
        /// <summary>
        /// Get or Set the API Model Validation Errors
        /// </summary>
        [XmlArray("model_errors")]
        [XmlArrayItem("add")]
        public List<ApiModelError> ModelErrors { get; set; }
    }
}
