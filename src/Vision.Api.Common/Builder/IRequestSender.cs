using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common.Builder
{
    public interface IRequestSender
    {
        /// <summary>
        /// Supported Http Methods
        /// </summary>
        HttpMethods[] SupportedMethods { get; }
        /// <summary>
        /// Supported Request Content Type
        /// </summary>
        string RequestContentType { get; }
        /// <summary>
        /// Send request and get response
        /// </summary>
        /// <param name="url"></param>
        /// <param name="requestData">request parameter, maybe IDictionary<string,string> or object </param>
        /// <param name="accept"></param>
        /// <param name="method"></param>
        /// <param name="headers"></param>
        /// <returns></returns>
        string Send(string url, object requestData, string accept, HttpMethods method, IDictionary<string,string> headers = null);
    }
}
