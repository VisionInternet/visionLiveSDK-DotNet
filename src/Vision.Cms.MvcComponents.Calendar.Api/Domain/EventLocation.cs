using System.Xml.Serialization;
using Vision.Api.Common;

namespace Vision.Cms.MvcComponents.Calendar.Api.Domain
{
    [ApiDataStructure]
    [XmlRoot(Namespace = ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE)]
    public class EventLocation
    {
        
        /// <summary>
        /// get or set the published event Location
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Location { get; set; }

        /// <summary>
        /// get or set the published event Address
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Address { get; set; }

        [XmlElement]
        [ApiDataStructureField]
        public string Address2 { get; set; }

        /// <summary>
        /// get or set the published event City
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string City { get; set; }
        
        /// <summary>
        /// get or set the published event State, ONLY Name
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string State { get; set; }

        /// <summary>
        /// get or set the published event PostCode 
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string PostCode { get; set; }

    }
}
