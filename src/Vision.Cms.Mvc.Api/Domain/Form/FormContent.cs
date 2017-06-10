using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Vision.Api.Common;

namespace Vision.Cms.Mvc.Api.Domain.Form
{
    /// <summary>
    /// Form content
    /// </summary>
    /// <seealso cref="Vision.Cms.Mvc.Api.Domain.IContent" />
    [ApiDataStructure]
    [ContentAPIName(ContentAPINameAttribute.Forms)]
    public class FormContent : IContent
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
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>
        /// The unique identifier.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public Guid Guid { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the open date.
        /// </summary>
        /// <value>
        /// The open date.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime? OpenDate { get; set; }

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
        /// Gets or sets a value indicating whether [question numbering disabled].
        /// </summary>
        /// <value>
        /// <c>true</c> if [question numbering disabled]; otherwise, <c>false</c>.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public bool QuestionNumberingDisabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [navigation enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [navigation enabled]; otherwise, <c>false</c>.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public bool NavigationEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="FormContent"/> is display.
        /// </summary>
        /// <value>
        ///   <c>true</c> if display; otherwise, <c>false</c>.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public bool Display { get; set; }

        /// <summary>
        /// Gets or sets the progress display mode.
        /// </summary>
        /// <value>
        /// The progress display mode.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public int ProgressDisplayMode { get; set; }

        /// <summary>
        /// Gets or sets the resume mode.
        /// </summary>
        /// <value>
        /// The resume mode.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public int ResumeMode { get; set; }

        /// <summary>
        /// Gets or sets the notification mode.
        /// </summary>
        /// <value>
        /// The notification mode.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public int NotificationMode { get; set; }

        /// <summary>
        /// Gets or sets the notification email subject.
        /// </summary>
        /// <value>
        /// The notification email subject.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string NotificationEmailSubject { get; set; }

        /// <summary>
        /// Gets or sets the notification email from.
        /// </summary>
        /// <value>
        /// The notification email from.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string NotificationEmailFrom { get; set; }

        /// <summary>
        /// Gets or sets the notification email to.
        /// </summary>
        /// <value>
        /// The notification email to.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string NotificationEmailTo { get; set; }

        /// <summary>
        /// Gets or sets the completion redirection URL.
        /// </summary>
        /// <value>
        /// The completion redirection URL.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string CompletionRedirectionUrl { get; set; }

        /// <summary>
        /// Gets or sets the completion message.
        /// </summary>
        /// <value>
        /// The completion message.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string CompletionMessage { get; set; }

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
