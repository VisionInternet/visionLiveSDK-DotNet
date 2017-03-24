using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    public interface IApiParser
    {
        /// <summary>
        /// Parse the response body to corresponding response domain object.
        /// </summary>
        /// <param name="body">response body</param>
        /// <returns>response domain object</returns>
        TResponse Parse<TResponse>(string body)
            where TResponse : class, IApiResponse;
    }
}
