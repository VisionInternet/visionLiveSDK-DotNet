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
    public class EventWaitingEmail
    {
        /// <summary>
        /// Get or set the waiting email
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Email { get; set; }

        /// <summary>
        /// Get or set the created date
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Get or set whether cms has sent waiting email notification
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public bool IsSent { get; set; }

        /// <summary>
        /// Get or set the waiting email notification sent date
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime? SentDate { get; set; }

        /// <summary>
        /// Get or set registration id, if the website user has registred an Event Registration, this field won't be NULL.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public int? RegistrationID { get; set; }

        /// <summary>
        /// Get or set submitted by. (Website User's email)
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string SubmittedBy { get; set; }

        /// <summary>
        /// Get or set the Event id of the waiting email
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public int EventID { get; set; }
    }
}
