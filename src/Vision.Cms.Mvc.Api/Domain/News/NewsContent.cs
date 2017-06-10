using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using Vision.Api.Common;

namespace Vision.Cms.Mvc.Api.Domain.News
{
    /// <summary>
    /// News content
    /// </summary>
    /// <seealso cref="Vision.Cms.Mvc.Api.Domain.IContent" />
    [ApiDataStructure]
    [ContentAPIName(ContentAPINameAttribute.News)]
    public class NewsContent : IContent
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
        /// get or set the published title
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Title { get; set; }

        /// <summary>
        /// get or set the published sub title
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string SubTitle { get; set; }

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
        /// get or set the published news RedirectTarget
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string RedirectTarget { get; set; }

        /// <summary>
        /// get or set the published ThumbnailImage URL
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string ThumbnailImage { get; set; }

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