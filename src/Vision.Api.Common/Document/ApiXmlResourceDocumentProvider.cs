using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vision.Api.Common.Document
{
    public class ApiXmlResourceDocumentProvider : IApiDocumentProvider
    {
        #region GetAllCategories
        public IEnumerable<ApiDocumentApiCategory> GetAllCategories(Assembly assembly)
        {
            var resourceFileName = string.Format("{0}.{0}.api", assembly.FullName.Split(',').First());
            var serializer = new XmlSerializer(typeof(ApiCategoriesData));
            var apiCategoriesData = new ApiCategoriesData();
            using (Stream stream = assembly.GetManifestResourceStream(resourceFileName))
            {
                apiCategoriesData = serializer.Deserialize(stream) as ApiCategoriesData;
            }
            return apiCategoriesData != null ? apiCategoriesData.Categories : new List<ApiDocumentApiCategory>();
        }
        #endregion
    }

    [XmlRoot("visionApi")]
    public class ApiCategoriesData
    {
        [XmlArray("categories")]
        [XmlArrayItem("category")]
        public List<ApiDocumentApiCategory> Categories { get; set; }
    }
}
