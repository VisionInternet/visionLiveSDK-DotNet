using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Vision.Cms.MvcComponents.ServiceRequest.Api;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Vision.Cms.MvcComponents.ServiceRequest.Api")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyProduct("Vision.Cms.MvcComponents.ServiceRequest.Api")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("2273e413-05c0-4f04-b650-e5c3ce4f949e")]

[assembly: Vision.Api.Common.ApiCategory(InternalConstants.ApiCategoryUniqueName,
                                         InternalConstants.ApiCategoryDisplayName)]
[assembly: Vision.Api.Common.ApiDocumentProvider(typeof(Vision.Api.Common.Document.ApiXmlResourceDocumentProvider))]