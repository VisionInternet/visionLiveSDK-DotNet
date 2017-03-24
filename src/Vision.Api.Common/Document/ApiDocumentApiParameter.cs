using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vision.Api.Common.Document
{
    [XmlRoot("param")]
    public class ApiDocumentApiParameter
    {
        #region Properties
        /// <summary>
        /// get or set the name, it's always the same as property name.
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// get or set the display name
        /// </summary>
        [XmlAttribute("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// get or set the description
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }
        #endregion
    }
}
