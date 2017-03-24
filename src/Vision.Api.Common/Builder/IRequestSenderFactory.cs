using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common.Builder
{
    public interface IRequestSenderFactory
    {
        void Register(IRequestSender requestSender);
        IRequestSender GetRequestSender(HttpMethods method, string contentType);
    }
}
