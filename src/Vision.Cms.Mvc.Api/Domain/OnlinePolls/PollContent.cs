using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Vision.Api.Common;

namespace Vision.Cms.Mvc.Api.Domain.OnlinePolls
{
    /// <summary>
    /// Online polls content
    /// </summary>
    [ApiDataStructure]
    [ContentAPIName(ContentAPINameAttribute.OnlinePolls)]
    public class PollContent : IContent
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
        /// Gets or sets a value indicating whether this <see cref="PollContent"/> is display.
        /// </summary>
        /// <value>
        ///   <c>true</c> if display; otherwise, <c>false</c>.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public bool Display { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [allow multiple].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow multiple]; otherwise, <c>false</c>.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public bool AllowMultiple { get; set; }

        /// <summary>
        /// Gets or sets the maximum selection count.
        /// </summary>
        /// <value>
        /// The maximum selection count.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public int? MaxSelectionCount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [randomize answers].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [randomize answers]; otherwise, <c>false</c>.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public bool RandomizeAnswers { get; set; }

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
        /// Gets or sets the close date.
        /// </summary>
        /// <value>
        /// The close date.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime? CloseDate { get; set; }

        /// <summary>
        /// Gets or sets the last vote date.
        /// </summary>
        /// <value>
        /// The last vote date.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime? LastVoteDate { get; set; }

        /// <summary>
        /// Gets or sets the thumbnail image.
        /// </summary>
        /// <value>
        /// The thumbnail image.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string ThumbnailImage { get; set; }

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
        /// get or set the published Departments
        /// </summary>
        [XmlArray]
        [XmlArrayItem]
        [ApiDataStructureField]
        public List<Department> Departments { get; set; }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        /// <value>
        /// The categories.
        /// </value>
        [XmlArray]
        [XmlArrayItem]
        [ApiDataStructureField]
        public List<Category> Categories { get; set; }

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
