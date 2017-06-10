using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision.Api.Common;
using Vision.Cms.Mvc.Api.Domain;
using Vision.Cms.Mvc.Api.Request;
using Vision.Cms.Mvc.Api.Response;

namespace Vision.Cms.Mvc.Api
{
    /// <summary>
    /// Contetn API service
    /// </summary>
    /// <typeparam name="TContent">The type of the model.</typeparam>
    public interface IContentAPIService<TContent> 
        where TContent : IContent
    {
        #region Interfaces
        /// <summary>
        /// Finds the content.
        /// </summary>
        /// <returns></returns>
        IEnumerable<TContent> FindContent(ContentFindRequest<TContent> model, out int totalCount, out bool hasNext);
        /// <summary>
        /// Gets the content.
        /// </summary>
        /// <returns></returns>
        TContent GetContent(ContentGetRequest<TContent> model, FilterFieldsType fields);
        #endregion
    }
}
