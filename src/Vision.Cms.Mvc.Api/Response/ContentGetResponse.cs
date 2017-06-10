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
    /// Content get response.
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    [ApiResponse]
    [XmlRoot(Namespace = ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE)]
    public class ContentGetResponse<TModel> : ApiResponse<ContentGetRequest<TModel>>
        where TModel : IContent
    {
        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        [XmlElement]
        [ApiResponseProperty]
        public TModel Content { get; set; }
    }
}