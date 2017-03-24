using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    public interface IApiClient
    {
        /// <summary>
        /// Execute the API Request with HttpPost
        /// </summary>
        /// <typeparam name="TRequest"></typeparam>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="request"></param>
        /// <param name="parser">the Parser for the Response.</param>
        /// <returns></returns>
        TResponse Execute<TRequest, TResponse>(TRequest request, IApiParser parser = null)
            where TRequest : ApiRequest
            where TResponse : ApiResponse<TRequest>, new();
        /// <summary>
        /// Execute the API Request with HttpPost
        /// </summary>
        /// <typeparam name="TRequest"></typeparam>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="request"></param>
        /// <param name="parser"></param>
        /// <returns></returns>
        Task<TResponse> ExecuteAsync<TRequest, TResponse>(TRequest request, IApiParser parser = null)
            where TRequest : ApiRequest
            where TResponse : ApiResponse<TRequest>, new(); 
    }
}
