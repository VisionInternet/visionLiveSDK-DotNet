using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vision.Api.Common.Domain
{
    [ApiDataStructure]
    [XmlRoot(Namespace = ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE)]
    public class PagingList<T>
    {
        /// <summary>
        /// Get or set the total results count.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public long TotalResults { get; set; }

        /// <summary>
        /// Get or set if exists next record.
        /// </summary>
        [XmlElement]
        [ApiDataStructureField]
        public bool HasNext { get; set; }

        /// <summary>
        /// Get or set the final record list.
        /// </summary>
        [XmlArray("Content")]
        [XmlArrayItem("Add")]
        [ApiDataStructureField]
        public List<T> Content { get; set; }
    }
}
