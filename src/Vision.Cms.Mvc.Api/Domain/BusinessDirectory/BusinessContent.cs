using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Vision.Api.Common;

namespace Vision.Cms.Mvc.Api.Domain.BusinessDirectory
{
    /// <summary>
    /// Business directory content
    /// </summary>
    /// <seealso cref="Vision.Cms.Mvc.Api.Domain.IContent" />
    [ApiDataStructure]
    [ContentAPIName(ContentAPINameAttribute.BusinessDirectory)]
    public class BusinessContent : IContent
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
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is private email.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is private email; otherwise, <c>false</c>.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public bool IsPrivateEmail { get; set; }

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
        /// Gets or sets the fax.
        /// </summary>
        /// <value>
        /// The fax.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string Fax { get; set; }

        /// <summary>
        /// Gets or sets the fax ext.
        /// </summary>
        /// <value>
        /// The fax ext.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string FaxExt { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="BusinessContent"/> is display.
        /// </summary>
        /// <value>
        ///   <c>true</c> if display; otherwise, <c>false</c>.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public bool Display { get; set; }

        /// <summary>
        /// Gets or sets the web URL.
        /// </summary>
        /// <value>
        /// The web URL.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string WebUrl { get; set; }

        /// <summary>
        /// Gets or sets the hours.
        /// </summary>
        /// <value>
        /// The hours.
        /// </value>
        [XmlElement]
        [ApiDataStructureField]
        public string Hours { get; set; }

        /// <summary>
        /// get or set the published Address1
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Address1 { get; set; }

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
        /// get or set the published PostalCode 
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string PostalCode { get; set; }

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
        /// get or set the published DisplayLinkToDocumentViewer
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public bool DisplayLinkToDocumentViewer { get; set; }

        /// <summary>
        /// get or set the published news Content
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Content { get; set; }

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
        /// get or set published ContentReview
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public ContentReview ContentReview { get; set; }
    }
}
