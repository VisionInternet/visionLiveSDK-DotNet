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
    public class EventRegistrationAttendee 
    {
        /// <summary>
        /// Get or set the attendee id
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public int ID { get; set; }

        /// <summary>
        /// Get or set whether the attendee is owner
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public bool IsOwner { get; set; }

        /// <summary>
        /// Get or set the organization name
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Get or set the attendee first name
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string FirstName { get; set; }

        /// <summary>
        /// Get or set the attendee last name
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string LastName { get; set; }

        /// <summary>
        /// Get or set the title
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Title { get; set; }

        /// <summary>
        /// Get or set the address
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Address { get; set; }

        /// <summary>
        /// Get or set the address2
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Address2 { get; set; }

        /// <summary>
        /// Get or set the city
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string City { get; set; }

        /// <summary>
        /// Get or set the state(Only name)
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string State { get; set; }

        /// <summary>
        /// Get or set the post code
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string PostCode { get; set; }

        /// <summary>
        /// Get or set the email
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Email { get; set; }

        /// <summary>
        /// Get or set the phone
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Phone { get; set; }

        /// <summary>
        /// Get or set the phone ext
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string PhoneExt { get; set; }

        /// <summary>
        /// Get or set the order
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public int Order { get; set; }

    }
}
