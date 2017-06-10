using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Vision.Api.Common;

namespace Vision.Cms.Mvc.Api.Domain.Calendar
{
    /// <summary>
    /// Event content
    /// </summary>
    /// <seealso cref="Vision.Cms.Mvc.Api.Domain.IContent" />
    [ApiDataStructure]
    [ContentAPIName(ContentAPINameAttribute.Calendar)]
    public class EventContent : IContent
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
        public string Title { get; set; }

        /// <summary>
        /// get  or set the published SubTitle
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string SubTitle { get; set; }

        /// <summary>
        /// get or set the published StartDate
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// get or set the published EndDate
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// get or set the published DisplayLinkToDocumentViewer
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public bool DisplayLinkToDocumentViewer { get; set; }

        /// <summary>
        /// get or set the pubished AllowNotification
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public bool AllowNotification { get; set; }

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
        /// get or set the published Location
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Location { get; set; }

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
        public string PostCode { get; set; }

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
        /// get or set the published event ThumbnailImage URL
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string ThumbnailImage { get; set; }

        /// <summary>
        /// get or set the published AllowRegistration
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public bool AllowRegistration { get; set; }

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
        /// Gets or sets the tags.
        /// </summary>
        /// <value>
        /// The tags.
        /// </value>
        [XmlArray]
        [XmlArrayItem]
        [ApiDataStructureField]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// get or set published ContentReview
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public ContentReview ContentReview { get; set; }
    }
}
