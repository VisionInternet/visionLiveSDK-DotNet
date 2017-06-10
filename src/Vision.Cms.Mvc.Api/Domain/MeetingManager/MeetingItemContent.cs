using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Vision.Api.Common;

namespace Vision.Cms.Mvc.Api.Domain.MeetingManager
{
    /// <summary>
    /// Meeting item content
    /// </summary>
    /// <seealso cref="Vision.Cms.Mvc.Api.Domain.IContent" />
    [ApiDataStructure]
    [ContentAPIName(ContentAPINameAttribute.MeetingItem)]
    public class MeetingItemContent : IContent
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
        /// get or set the published DisplayLinkToDocumentViewer
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public bool DisplayLinkToDocumentViewer { get; set; }

        /// <summary>
        /// get or set the published Content
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the type of the item.
        /// </summary>
        /// <value>
        /// The type of the item.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string ItemType { get; set; }

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
        /// Gets or sets the original identifier.
        /// </summary>
        /// <value>
        /// The original identifier.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public int? OriginalID { get; set; }

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
        /// Gets or sets the suggested date.
        /// </summary>
        /// <value>
        /// The suggested date.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime SuggestedDate { get; set; }

        /// <summary>
        /// Gets or sets the video URL.
        /// </summary>
        /// <value>
        /// The video URL.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string VideoUrl { get; set; }

        /// <summary>
        /// Gets or sets the video URL target.
        /// </summary>
        /// <value>
        /// The video URL target.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string VideoUrlTarget { get; set; }

        /// <summary>
        /// Gets or sets the sponsors.
        /// </summary>
        /// <value>
        /// The sponsors.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string Sponsors { get; set; }

        /// <summary>
        /// Gets or sets the post date.
        /// </summary>
        /// <value>
        /// The post date.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime? PostDate { get; set; }

        /// <summary>
        /// get or set the published Departments
        /// </summary>
        [XmlArray]
        [XmlArrayItem]
        [ApiDataStructureField]
        public List<Department> Departments { get; set; }
    }
}
