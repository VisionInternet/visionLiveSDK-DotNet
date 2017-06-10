using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using Vision.Api.Common;
using Vision.Cms.Mvc.Api.Domain;
using Vision.Cms.Mvc.Api.Request;

namespace Vision.Cms.Mvc.Api.Response
{
    /// <summary>
    /// Content find response
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    [ApiResponse]
    [XmlRoot(Namespace = ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE)]
    public class ContentFindResponse<TModel> : ApiResponse<ContentFindRequest<TModel>>
        where TModel : IContent
    {
        /// <summary>
        /// Gets or sets the paging list.
        /// </summary>
        /// <value>
        /// The paging list.
        /// </value>
        [XmlElement]
        [ApiResponseProperty]
        public Vision.Api.Common.Domain.PagingList<TModel> PagingList { get; set; }
    }
}