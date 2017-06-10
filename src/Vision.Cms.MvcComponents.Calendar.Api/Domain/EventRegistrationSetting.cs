using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Vision.Api.Common;

namespace Vision.Cms.MvcComponents.Calendar.Api.Domain
{
    [ApiDataStructure]
    [XmlRoot(Namespace = ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE)]
    public class EventRegistrationSetting
    {
        /// <summary>
        /// get or set  event registrastion DeadLine
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime DeadLine { get; set; }

        /// <summary>
        /// get or set  event registrastion MaxNumber
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public int MaxNumber { get; set; }

        /// <summary>
        /// get or set  event registrastion Fee
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public decimal Fee { get; set; }

        /// <summary>
        /// get or set  event registrastion ContactPhone
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string ContactPhone { get; set; }

        /// <summary>
        /// get or set  event registrastion ContactPhoneExt
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string ContactPhoneExt { get; set; }

        /// <summary>
        /// get or set  event registrastion WaitingMessage
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string WaitingMessage { get; set; }

        /// <summary>
        /// get or set  event registrastion AllowWaitingList
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public bool AllowWaitingList { get; set; }

        /// <summary>
        /// get or set  event registrastion DisplayContactPhone
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public bool DisplayContactPhone { get; set; }

        /// <summary>
        /// get or set  event registrastion DisplayContactEmail
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public bool DisplayContactEmail { get; set; }

        /// <summary>
        /// get or set  event registrastion DisplayWaitingMessage
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public bool DisplayWaitingMessage { get; set; }

        /// <summary>
        /// get or set  event registrastion EnableWaitingListEnotification
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public bool EnableWaitingListEnotification { get; set; }

    }
}
