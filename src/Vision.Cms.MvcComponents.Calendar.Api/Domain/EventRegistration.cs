using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Vision.Api.Common;

namespace Vision.Cms.MvcComponents.Calendar.Api.Domain
{
    [ApiDataStructure]
    [XmlRoot(Namespace = ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE)]
    public class EventRegistration
    {
        /// <summary>
        /// Get or set the published event id
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public int EventID { get; set; }

        /// <summary>
        /// Get or set the event registration id
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public int ID { get; set; }

        /// <summary>
        /// Get or set event registration GUID
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public Guid GUID { get; set; }

        /// <summary>
        /// Get or set event registration status
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string RegistrationStatus { get; set; }

        /// <summary>
        /// Get or set the created date
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime RegisterredDate  { get; set; }

        /// <summary>
        /// Get or set submitted by. (Website User's email)
        /// Ifsubmitted by CMS user, return NULL
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string SubmittedBy { get; set; }

        /// <summary>
        /// Get or set registration fee status
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string RegistrationFeeStatus { get; set; }

        /// <summary>
        /// Get or set the transaction id
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string TransactionID { get; set; }

        /// <summary>
        /// Get or set whether submitted from frontend
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public bool FromFrontend { get; set; }

        /// <summary>
        /// Get or set total fee.
        /// Not get this value now.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public decimal TotalFee { get; set; }

        [XmlArray]
        [XmlArrayItem]
        [ApiDataStructureField]
        public List<EventRegistrationAttendee> Attendees { get; set; }
    }
}
