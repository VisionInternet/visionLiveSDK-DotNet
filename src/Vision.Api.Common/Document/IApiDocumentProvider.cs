using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common.Document
{
    public interface IApiDocumentProvider
    {
        IEnumerable<ApiDocumentApiCategory> GetAllCategories(Assembly assembly);
    }
}
