using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vision.Api.Common.Document
{
    [XmlRoot("field")]
    public class ApiDocumentApiDataStructureField
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("displayName")]
        public string DisplayName { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }
    }
}
