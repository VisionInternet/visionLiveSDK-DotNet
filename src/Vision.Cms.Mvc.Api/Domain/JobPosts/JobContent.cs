using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Vision.Api.Common;

namespace Vision.Cms.Mvc.Api.Domain.JobPosts
{
    /// <summary>
    /// Job posts content
    /// </summary>
    [ApiDataStructure]
    [ContentAPIName(ContentAPINameAttribute.JobPosts)]
    public class JobContent : IContent
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
        /// Gets or sets the salary.
        /// </summary>
        /// <value>
        /// The salary.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string Salary { get; set; }

        /// <summary>
        /// Gets or sets the type of the job.
        /// </summary>
        /// <value>
        /// The type of the job.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string JobType { get; set; }

        /// <summary>
        /// Gets or sets the publish date.
        /// </summary>
        /// <value>
        /// The publish date.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime? PublishDate { get; set; }

        /// <summary>
        /// Gets or sets the expire date.
        /// </summary>
        /// <value>
        /// The expire date.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime? ExpireDate { get; set; }

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
        /// Gets or sets a value indicating whether this <see cref="JobContent"/> is display.
        /// </summary>
        /// <value>
        ///   <c>true</c> if display; otherwise, <c>false</c>.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public bool Display { get; set; }

        /// <summary>
        /// Gets or sets the additional details.
        /// </summary>
        /// <value>
        /// The additional details.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string AdditionalDetails { get; set; }

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
        /// Gets or sets a value indicating whether [allow online application].
        /// </summary>
        /// <value>
        /// <c>true</c> if [allow online application]; otherwise, <c>false</c>.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public bool AllowOnlineApplication { get; set; }

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
