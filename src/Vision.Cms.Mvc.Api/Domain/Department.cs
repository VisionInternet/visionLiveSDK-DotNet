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
   public class Department
    {
        /// <summary>
        /// get or set DepartmentID
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public int ID { get; set; }

        /// <summary>
        /// get or set Department Name
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public string Name { get; set; }
    }
}
