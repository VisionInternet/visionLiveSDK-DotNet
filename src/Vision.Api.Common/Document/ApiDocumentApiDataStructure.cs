using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vision.Api.Common.Document
{
    [XmlRoot("data")]
    public class ApiDocumentApiDataStructure
    {
        [XmlAttribute("type")]
        public string TypeName { get; set; }

        [XmlAttribute("displayName")]
        public string DisplayName { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlArray("fields")]
        [XmlArrayItem("field")]
        public List<ApiDocumentApiDataStructureField> Fields { get; set; }
    }
}
