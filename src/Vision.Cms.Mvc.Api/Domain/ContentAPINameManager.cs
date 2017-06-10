using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Cms.Mvc.Api.Domain
{
    public class ContentAPINameManager
    {
        #region Fields
        static readonly IDictionary<string, Type> ContentApiInfoDictionary = new Dictionary<string, Type>();
        #endregion

        #region Static Ctor
        static ContentAPINameManager()
        {
            var allContentTypes = typeof(ContentAPINameManager).Assembly.GetTypes().Where(a => typeof(IContent).IsAssignableFrom(a)).ToList();
            foreach (var type in allContentTypes)
            {
                var attribute = type.GetCustomAttributes(typeof(ContentAPINameAttribute), false).Cast<ContentAPINameAttribute>().FirstOrDefault();
                if (attribute != null)
                {
                    ContentApiInfoDictionary[attribute.Name] = type;
                }
            }
        }
        #endregion

        #region Method

        public static string GetContentApiName(Type contentApiType)
        {
            return ContentApiInfoDictionary.Where(a => a.Value == contentApiType).Select(a => a.Key).FirstOrDefault();
        }

        public static Type GetContentApiType(string contentApiName)
        {
            return ContentApiInfoDictionary.Where(a => a.Key.Equals(contentApiName, StringComparison.InvariantCultureIgnoreCase)).Select(a => a.Value).FirstOrDefault();
        }
        #endregion
    }
}
