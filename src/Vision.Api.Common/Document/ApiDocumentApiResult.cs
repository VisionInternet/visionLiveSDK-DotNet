using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vision.Api.Common.Document
{
    [XmlRoot("result")]
    public class ApiDocumentApiResult
    {
        #region Ctor
        public ApiDocumentApiResult()
        {
            Fields = new List<ApiDocumentApiResultField>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// get or set the name, it's always the same of type name(including the namespace)
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
        [XmlElement("displayName")]
        public string Description { get; set; }

        /// <summary>
        /// get or set the fields
        /// </summary>
        [XmlArray("fields")]
        [XmlArrayItem("field")]
        public List<ApiDocumentApiResultField> Fields { get; set; }
        #endregion
    }
}
