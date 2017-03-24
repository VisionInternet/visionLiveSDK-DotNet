using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Vision.Api.Common;
using Vision.Api.Common.Domain;
using Vision.Cms.MvcComponents.ServiceRequest.Api.Request;

namespace Vision.Cms.MvcComponents.ServiceRequest.Api.Response
{
    [XmlRoot(Namespace = ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE)]
    [ApiResponse]
    public class ServiceRequestTopicFindResponse : ApiResponse<ServiceRequestTopicFindRequest>
    {
        [XmlElement]
        [ApiResponseProperty]
        public PagingList<Vision.Cms.MvcComponents.ServiceRequest.Api.Domain.ServiceRequestTopic> PagingList { get; set; }
    }
}
