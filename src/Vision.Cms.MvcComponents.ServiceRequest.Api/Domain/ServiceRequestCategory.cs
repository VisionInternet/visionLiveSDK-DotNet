using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Vision.Api.Common;

namespace Vision.Cms.MvcComponents.ServiceRequest.Api.Domain
{
    [XmlRoot(Namespace = ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE)]
    [ApiDataStructure]
    public class ServiceRequestCategory
    {
        [XmlElement]
        [ApiDataStructureField]
        public int ID { get; set; }

        [XmlElement]
        [ApiDataStructureField]
        public string Name { get; set; }

        [XmlElement]
        [ApiDataStructureField]
        public DateTime LastUpdatedDate { get; set; }

        [XmlElement]
        [ApiDataStructureField]
        public string LastUpdatedBy { get; set; }

        [XmlElement]
        [ApiDataStructureField]
        public List<ServiceRequestTopic> ServiceRequestTopics { get; set; }
    }
}
