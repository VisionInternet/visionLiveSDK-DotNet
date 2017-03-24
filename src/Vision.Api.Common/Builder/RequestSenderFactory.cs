using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common.Builder
{
    public class RequestSenderFactory : IRequestSenderFactory
    {
        #region Ctor
        readonly List<IRequestSender> _requestSenders = new List<IRequestSender>();
        public RequestSenderFactory()
        {
            _requestSenders.Add(new RawJsonRequestSender());
            _requestSenders.Add(new FormDataRequestSender());
            _requestSenders.Add(new QueryStringRequestSender());
        }
        #endregion

        #region Methods
        public void Register(IRequestSender requestSender)
        {
            _requestSenders.Add(requestSender);
        }

        public IRequestSender GetRequestSender(HttpMethods method, string contentType)
        {
            return _requestSenders.FirstOrDefault(a => a.RequestContentType.Equals(contentType, StringComparison.CurrentCultureIgnoreCase) && a.SupportedMethods.Contains(method));
        }
        #endregion
    }
}
