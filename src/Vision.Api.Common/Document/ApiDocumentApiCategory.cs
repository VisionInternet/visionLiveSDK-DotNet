using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vision.Api.Common.Document
{
    [XmlRoot("category")]
    public class ApiDocumentApiCategory
    {
        #region Ctor
        public ApiDocumentApiCategory()
        {
            Apis = new List<ApiDocumentApi>();
            Datas = new List<ApiDocumentApiDataStructure>(); 
        }
        #endregion

        #region Properties
        /// <summary>
        /// get or set the name
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
        /// get or set whether it's the default category in the assembly.
        /// </summary>
        [XmlAttribute("isDefault")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// get or set the apis in the category
        /// </summary>
        [XmlArray("apis")]
        [XmlArrayItem("api")]
        public List<ApiDocumentApi> Apis { get; set; }

        /// <summary>
        /// get or set the data structure in the category
        /// </summary>
        [XmlArray("datas")]
        [XmlArrayItem("data")]
        public List<ApiDocumentApiDataStructure> Datas { get; set; }
        #endregion
    }
}
