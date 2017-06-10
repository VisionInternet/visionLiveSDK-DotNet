using System.Xml.Serialization;
using Vision.Api.Common;
using Vision.Cms.MvcComponents.Calendar.Api.Domain;
using Vision.Cms.MvcComponents.Calendar.Api.Request;

namespace Vision.Cms.MvcComponents.Calendar.Api.Response
{
    [ApiResponse]
    [XmlRoot(Namespace = ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE)]
    public class EventLocationGetResponse : ApiResponse<EventLocationGetRequest>
    {
        [XmlElement]
        [ApiResponseProperty]
        public EventLocation EventLocation { get; set; }
    }
}
