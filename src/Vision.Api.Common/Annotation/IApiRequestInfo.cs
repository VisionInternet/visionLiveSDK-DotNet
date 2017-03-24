using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    public interface IApiRequestInfo
    {
        string Url { get; }
        HttpMethods Method { get; }
        string ContentType { get; }
    }
}
