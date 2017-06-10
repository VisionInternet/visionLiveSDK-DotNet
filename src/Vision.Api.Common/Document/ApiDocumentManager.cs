using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common.Document
{
    public class ApiDocumentManager
    {
        #region Static
        static readonly IApiDocumentProvider DefaultDocumentProvider = new ApiAttributeDocumentProvider();
        static readonly IEnumerable<Assembly> ExecuteAssemblies = AppDomain.CurrentDomain.GetAssemblies().Distinct();

        static ApiDocumentManager()
        {
            var assemblies = new List<Assembly>();
            var exepath = Path.GetDirectoryName(new System.Uri(typeof(ApiDocumentManager).Assembly.CodeBase).LocalPath);
            if (exepath.IndexOf("file:\\") >= 0)
                exepath = exepath.Substring("file:\\".Length);
            var dllFiles = Directory.GetFiles(exepath, "*.dll");
            foreach (var dllFile in dllFiles)
            {
                assemblies.Add(Assembly.LoadFrom(dllFile));
            }
            ExecuteAssemblies = assemblies;
        }
        #endregion

        #region Ctor
        public ApiDocumentManager(params Assembly[] assemblies)
        {
            var allAssemblies = assemblies;
            if (!allAssemblies.Any())
            {
                allAssemblies = ExecuteAssemblies.ToArray();
            }

            AssemblyDocumentProviderMapping = new Dictionary<Assembly, IApiDocumentProvider>();
            foreach (var assembly in allAssemblies.Where(c => c.FullName.StartsWith("Vision.")))
            {
                if (!AssemblyDocumentProviderMapping.Any(c => c.Key.FullName.Equals(assembly.FullName)))
                {
                    var apiDocumentProvider = DefaultDocumentProvider;
                    var apiDocumentProviderAttribute = assembly.GetCustomAttribute<ApiDocumentProviderAttribute>();
                    if (apiDocumentProviderAttribute != null && apiDocumentProviderAttribute.ApiDocumentProviderType != null
                                                          && typeof(IApiDocumentProvider).IsAssignableFrom(apiDocumentProviderAttribute.ApiDocumentProviderType))
                    {
                        apiDocumentProvider = Activator.CreateInstance(apiDocumentProviderAttribute.ApiDocumentProviderType) as IApiDocumentProvider;
                    }

                    AssemblyDocumentProviderMapping[assembly] = apiDocumentProvider;
                }
            }
        }
        #endregion

        #region Properties
        protected IDictionary<Assembly, IApiDocumentProvider> AssemblyDocumentProviderMapping { get; private set; }
        #endregion

        #region Methods
        /// <summary>
        /// get all Api Document Categories
        /// </summary>
        /// <param name="includingApiDetail"></param>
        /// <returns></returns>
        public IEnumerable<ApiDocumentApiCategory> GetAllCategories(bool includingApiDetail = true)
        {
            var categories = new List<ApiDocumentApiCategory>();
            foreach (var keyValue in AssemblyDocumentProviderMapping)
            {
                categories.AddRange(keyValue.Value.GetAllCategories(keyValue.Key));
            }
            return categories;
        }

        /// <summary>
        /// add assembly with document provider
        /// </summary>
        /// <param name="assembly"></param>
        /// <param name="documentProvider"></param>
        public void AddAssembly(Assembly assembly, IApiDocumentProvider documentProvider)
        {
            var existingKey = AssemblyDocumentProviderMapping.Keys.Where(c => c.FullName.Equals(assembly.FullName)).FirstOrDefault();
            if (existingKey != null)
                AssemblyDocumentProviderMapping[existingKey] = documentProvider;
            else
                AssemblyDocumentProviderMapping[assembly] = documentProvider;
        }
        #endregion
    } 
}
