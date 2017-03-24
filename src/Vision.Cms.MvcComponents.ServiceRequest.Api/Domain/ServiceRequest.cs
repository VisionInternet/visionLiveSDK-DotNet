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
    public class ServiceRequest
    {
        /// <summary>
        /// Get or set service request id.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public int ID { get; set; }

        /// <summary>
        /// Get or set service request status.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Status { get; set; }

        /// <summary>
        /// Get or set service request topic.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Topic { get; set; }

        /// <summary>
        /// Get or set service request reported date.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime ReportedOn { get; set; }

        /// <summary>
        /// Get or set service request reporter email.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string ReportedBy { get; set; }

        /// <summary>
        /// Get or set the email of whom assign to.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string AssignedTo { get; set; }

        /// <summary>
        /// Get or set service request last modified date.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Get or set service request last modifier.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// Get or set service request expected close date.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime ExpectedCloseDate { get; set; }

        /// <summary>
        /// Get or set service request subject.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Subject { get; set; }

        /// <summary>
        /// Get or set service request location.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Location { get; set; }

        /// <summary>
        /// Get or set service request date.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Get or set service request cc email list.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string CcEmailList { get; set; }
    }
}
