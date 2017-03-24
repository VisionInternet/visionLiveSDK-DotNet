using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Vision.Api.Common;
using Vision.Cms.MvcComponents.Calendar.Api.Domain;
using Vision.Cms.MvcComponents.Calendar.Api.Request;

namespace Vision.Cms.MvcComponents.Calendar.Api.Response
{
    [ApiResponse]
    [XmlRoot(Namespace = ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE)]
    public class EventGetResponse : ApiResponse<EventGetRequest>
    {
        [XmlElement]
        [ApiResponseProperty]
        public Event Event { get; set; }
    }
}
