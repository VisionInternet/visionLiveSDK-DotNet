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
    public class ServiceRequestTopic
    {
        [XmlElement]
        [ApiDataStructureField]
        public int ID { get; set; }

        [XmlElement]
        [ApiDataStructureField]
        public string Name { get; set; }

        [XmlElement]
        [ApiDataStructureField]
        public int ProcessTime { get; set; }

        [XmlElement]
        [ApiDataStructureField]
        public string CcEmailList { get; set; }

        [XmlElement]
        [ApiDataStructureField]
        public string Description { get; set; }

        [XmlElement]
        [ApiDataStructureField]
        public bool IsDateRequired { get; set; }

        [XmlElement]
        [ApiDataStructureField]
        public bool IsLocationRequired { get; set; }

        [XmlElement]
        [ApiDataStructureField]
        public string AssignedProcessor { get; set; }

        [XmlElement]
        [ApiDataStructureField]
        public string Category { get; set; }
    }
}
