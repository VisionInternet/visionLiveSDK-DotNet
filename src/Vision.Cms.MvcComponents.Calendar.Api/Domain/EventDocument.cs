using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Vision.Api.Common;

namespace Vision.Cms.MvcComponents.Calendar.Api.Domain
{
    [ApiDataStructure]
    [XmlRoot(Namespace = ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE)]
    public class EventDocument
    {
        /// <summary>
        /// get or set event document ID
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public long ID { get; set; }

        /// <summary>
        /// get or set event document Type
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public int Type { get; set; }

        /// <summary>
        /// get or set event document FileID
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public int FileID { get; set; }

        /// <summary>
        /// get or set event document EventID
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public int EventID { get; set; }

        /// <summary>
        /// get or set event DocumentSource
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public int DcoumentSource { get; set; }
    }
}
