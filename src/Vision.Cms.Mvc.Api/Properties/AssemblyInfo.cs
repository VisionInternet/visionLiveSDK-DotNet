using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices; 

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Vision.Cms.Mvc.Api")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyProduct("Vision.Cms.Mvc.Api")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("e80cf959-d245-46df-8b95-3b52db70bdbe")]


[assembly: Vision.Api.Common.ApiCategory(Vision.Cms.Mvc.Api.InternalConstants.ApiCategoryUniqueName_System,
                                         Vision.Cms.Mvc.Api.InternalConstants.ApiCategoryDisplayName_System, true)]
[assembly:Vision.Api.Common.ApiDocumentProvider(typeof(Vision.Api.Common.Document.ApiXmlResourceDocumentProvider))]
