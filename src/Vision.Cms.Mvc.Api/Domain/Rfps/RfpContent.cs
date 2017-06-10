using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Vision.Api.Common;

namespace Vision.Cms.Mvc.Api.Domain.Rfp
{
    /// <summary>
    /// Rfp content
    /// </summary>
    /// <seealso cref="IContent" />
    [ApiDataStructure]
    [ContentAPIName(ContentAPINameAttribute.Rfp)]
    public class RfpContent : IContent
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
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="RfpContent"/> is display.
        /// </summary>
        /// <value>
        ///   <c>true</c> if display; otherwise, <c>false</c>.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public bool Display { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [display on homepage].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [display on homepage]; otherwise, <c>false</c>.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public bool DisplayOnHomepage { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the closing date.
        /// </summary>
        /// <value>
        /// The closing date.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime? ClosingDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [allow notification].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow notification]; otherwise, <c>false</c>.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public bool AllowNotification { get; set; }

        /// <summary>
        /// Gets or sets the RFP status.
        /// </summary>
        /// <value>
        /// The RFP status.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string RfpStatus { get; set; }

        /// <summary>
        /// Gets or sets the RFP final status.
        /// </summary>
        /// <value>
        /// The RFP final status.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string RfpFinalStatus { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        /// <value>
        /// The details.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string Details { get; set; }

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
