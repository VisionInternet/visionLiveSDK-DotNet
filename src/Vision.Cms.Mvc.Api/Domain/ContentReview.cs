using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Vision.Api.Common;

namespace Vision.Cms.Mvc.Api
{
    [ApiDataStructure]
    [XmlRoot(Namespace = ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE)]
    public class ContentReview
    {
        /// <summary>
        /// get or set contentReview  CustomDate
        /// null is other scheduleType
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public DateTime? CustomDate { get; set; }

        /// <summary>
        /// get or set contentReview  ScheduleType
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public int ScheduleType { get; set; }
    }
}
