using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vision.Api.Common.Document
{
    [XmlRoot("api")]
    public class ApiDocumentApi
    {
        #region Ctor
        public ApiDocumentApi()
        {
            Parameters = new List<ApiDocumentApiParameter>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// get or set the name, it's the unique Api Name.
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

        /// <summary>
        /// get or set the parameter
        /// </summary>
        [XmlArray("params")]
        [XmlArrayItem("param")]
        public List<ApiDocumentApiParameter> Parameters { get; set; }

        /// <summary>
        /// get or set the result.
        /// </summary>
        [XmlElement("result")]
        public ApiDocumentApiResult Result { get; set; }
        #endregion

    }
}
