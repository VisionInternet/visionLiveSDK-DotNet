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
    public class ServiceRequestPost
    {
        /// <summary>
        /// Get or set service request post content.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Content { get; set; }

        /// <summary>
        /// Get or set the flag which indicates service request is internal or not.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public bool IsInternal { get; set; }

        /// <summary>
        /// Get or set the flag which indicates service request is comment or not.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public bool IsComment { get; set; }

        /// <summary>
        /// Get or set poster of service request post.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string PostBy { get; set; }

        /// <summary>
        /// Get or set the service request id of service request post.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public int ServiceRequestID { get; set; }

        /// <summary>
        /// Get or set the documents of service request post.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public List<string> Documents { get; set; }
    }
}
