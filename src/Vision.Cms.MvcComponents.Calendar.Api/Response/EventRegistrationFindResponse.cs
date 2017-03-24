using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Vision.Api.Common;
using Vision.Api.Common.Domain;
using Vision.Cms.MvcComponents.Calendar.Api.Domain;
using Vision.Cms.MvcComponents.Calendar.Api.Request;

namespace Vision.Cms.MvcComponents.Calendar.Api.Response
{
    [ApiResponse]
    [XmlRoot(Namespace = ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE)]
    public class EventRegistrationFindResponse : Vision.Api.Common.ApiResponse<EventRegistrationFindRequest>
    {
        /// <summary>
        /// doesn't get Attendees field value 
        /// </summary>
        [XmlElement]
        [ApiResponseProperty]
        public PagingList<EventRegistration> PagingList { get; set; }
    }
}
