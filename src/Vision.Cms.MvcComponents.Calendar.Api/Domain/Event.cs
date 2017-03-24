using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Vision.Api.Common;
using Vision.Cms.Mvc.Api;

namespace Vision.Cms.MvcComponents.Calendar.Api.Domain
{
    [ApiDataStructure]
    [XmlRoot(Namespace = ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE)]
    public class Event
    {
        /// <summary>
        /// get or set the published event ID
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public int ID { get; set; }
        
        /// <summary>
        /// get or set the published event Title
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Title { get; set; }
        
        /// <summary>
        /// get  or set the published event SubTitle
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string SubTitle { get; set; }

        /// <summary>
        /// get or set the published event StartDate
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// get or set the published event EndDate
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// get or set the published event DisplayLinkToDocumentViewer
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public bool DisplayLinkToDocumentViewer { get; set; }

        /// <summary>
        /// get or set the pubished event AllowNotification
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public bool AllowNotification { get; set; }

        /// <summary>
        /// get or set the published event Content
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Content { get; set; }

        /// <summary>
        /// get or set the published event RedirectURL
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string RedirectURL { get; set; }

        /// <summary>
        /// get or set the published event RedirectTarget
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string RedirectTarget { get; set; }

        /// <summary>
        /// get or set the published event Location
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Location { get; set; }

        /// <summary>
        /// get or set the published event Address
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Address { get; set; }

        [XmlElement]
        [ApiDataStructureField]
        public string Address2 { get; set; }

        /// <summary>
        /// get or set the published event City
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string City { get; set; }
        
        /// <summary>
        /// get or set the published event State, ONLY Name
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string State { get; set; }

        /// <summary>
        /// get or set the published event PostCode 
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string PostCode { get; set; }

        /// <summary>
        /// get or set the published event ThumbnailImage URL
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string ThumbnailImage { get; set; }

        /// <summary>
        /// get or set the published event AllowRegistration
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public bool AllowRegistration { get; set; }

        /// <summary>
        /// get or set the published event RegistrationSetting
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public EventRegistrationSetting RegistrationSetting { get; set; }

        /// <summary>
        /// get or set the published event Documents
        /// </summary>
        [XmlArray]
        [XmlArrayItem]
        [ApiDataStructureField]
        public List<EventDocument> Documents { get; set; }

        /// <summary>
        /// get or set the published event Categories
        /// </summary>
        [XmlArray]
        [XmlArrayItem]
        [ApiDataStructureField]
        public List<Category> Categories { get; set; }

        /// <summary>
        /// get or set the published event Departments
        /// </summary>
        [XmlArray]
        [XmlArrayItem]
        [ApiDataStructureField]
        public List<Department> Departments { get; set; }

        /// <summary>
        /// get or set the published event MemberGroups
        /// </summary>
        [XmlArray]
        [XmlArrayItem]
        [ApiDataStructureField]
        public List<MemberGroup> MemberGroups { get; set; }
      
        /// <summary>
        /// get or set published event ContentReview
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public ContentReview ContentReview { get; set; }
    }
}
