using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vision.Api.Common
{
    /// <summary>
    /// Model Error for some Model Related API. (Add/Update Model)
    /// </summary>
    [XmlRoot(Namespace = ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE)]
    public class ApiModelError
    {
        /// <summary>
        /// Get or Set the Property Name of the Model Error
        /// </summary>
        [XmlElement]
        public string Member { get; set; }

        /// <summary>
        /// Get or Set the Error Message
        /// </summary>
        [XmlElement]
        public string Message { get; set; }
    }
}
