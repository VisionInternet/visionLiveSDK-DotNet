using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Vision.Api.Common;

namespace Vision.Cms.Mvc.Api.Domain.FacilityDirectory
{
    /// <summary>
    /// Facility directory content.
    /// </summary>
    [ApiDataStructure]
    [ContentAPIName(ContentAPINameAttribute.FacilityDirectory)]
    public class FacilityContent : IContent
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public int ID { get; set; }

        /// <summary>
        /// get or set the published name
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Name { get; set; }

        /// <summary>
        /// get or set the published Content
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Content { get; set; }

        /// <summary>
        /// get or set the published RedirectURL
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string RedirectURL { get; set; }

        /// <summary>
        /// get or set the published RedirectTarget
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string RedirectTarget { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="FacilityContent"/> is display.
        /// </summary>
        /// <value>
        ///   <c>true</c> if display; otherwise, <c>false</c>.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public bool Display { get; set; }

        /// <summary>
        /// get or set the published Address
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the address2.
        /// </summary>
        /// <value>
        /// The address2.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string Address2 { get; set; }

        /// <summary>
        /// get or set the published City
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string City { get; set; }

        /// <summary>
        /// get or set the published State, ONLY Name
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string State { get; set; }

        /// <summary>
        /// get or set the published PostCode 
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the phone ext.
        /// </summary>
        /// <value>
        /// The phone ext.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string PhoneExt { get; set; }

        /// <summary>
        /// Gets or sets the extend field1.
        /// </summary>
        /// <value>
        /// The extend field1.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        [StringLength(1500)]
        public string ExtendField1 { get; set; }

        /// <summary>
        /// Gets or sets the extend field2.
        /// </summary>
        /// <value>
        /// The extend field2.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        [StringLength(1500)]
        public string ExtendField2 { get; set; }

        /// <summary>
        /// Gets or sets the extend field3.
        /// </summary>
        /// <value>
        /// The extend field3.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        [StringLength(1500)]
        public string ExtendField3 { get; set; }

        /// <summary>
        /// Gets or sets the extend field4.
        /// </summary>
        /// <value>
        /// The extend field4.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        [StringLength(1500)]
        public string ExtendField4 { get; set; }

        /// <summary>
        /// Gets or sets the extend field5.
        /// </summary>
        /// <value>
        /// The extend field5.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        [StringLength(1500)]
        public string ExtendField5 { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [display link to document viewer].
        /// </summary>
        /// <value>
        /// <c>true</c> if [display link to document viewer]; otherwise, <c>false</c>.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public bool DisplayLinkToDocumentViewer { get; set; }

        /// <summary>
        /// get or set the published ThumbnailImage URL
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string ThumbnailImage { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        /// <value>
        /// The latitude.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        /// <value>
        /// The longitude.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string Longitude { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [allow reservation].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow reservation]; otherwise, <c>false</c>.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public bool AllowReservation { get; set; }

        /// <summary>
        /// Gets or sets the reservation fee.
        /// </summary>
        /// <value>
        /// The reservation fee.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public decimal? ReservationFee { get; set; }

        /// <summary>
        /// Gets or sets the type of the reservation fee.
        /// </summary>
        /// <value>
        /// The type of the reservation fee.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public int ReservationFeeType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [reservation allow hourly].
        /// </summary>
        /// <value>
        /// <c>true</c> if [reservation allow hourly]; otherwise, <c>false</c>.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public bool ReservationAllowHourly { get; set; }

        /// <summary>
        /// Gets or sets the reservation maximum hours.
        /// </summary>
        /// <value>
        /// The reservation maximum hours.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public int? ReservationMaxHours { get; set; }

        /// <summary>
        /// Gets or sets the reservation confirmation instruction.
        /// </summary>
        /// <value>
        /// The reservation confirmation instruction.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string ReservationConfirmationInstruction { get; set; }

        /// <summary>
        /// get or set the published Categories
        /// </summary>
        [XmlArray]
        [XmlArrayItem]
        [ApiDataStructureField]
        public List<Category> Categories { get; set; }

        /// <summary>
        /// get or set the published Departments
        /// </summary>
        [XmlArray]
        [XmlArrayItem]
        [ApiDataStructureField]
        public List<Department> Departments { get; set; }

        /// <summary>
        /// get or set the published MemberGroups
        /// </summary>
        [XmlArray]
        [XmlArrayItem]
        [ApiDataStructureField]
        public List<MemberGroup> MemberGroups { get; set; }

        /// <summary>
        /// get or set published ContentReview
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public ContentReview ContentReview { get; set; }
    }
}
