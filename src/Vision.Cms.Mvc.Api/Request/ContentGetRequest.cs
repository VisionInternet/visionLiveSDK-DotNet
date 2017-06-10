using Vision.Api.Common;
using Vision.Api.Common.Request;
using Vision.Cms.Mvc.Api.Domain;

namespace Vision.Cms.Mvc.Api.Request
{
    /// <summary>
    /// Content get request
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    /// <seealso cref="Vision.Cms.Mvc.Api.Request.ContentRequest{TModel}" />
    [ApiName("cms.core.system.content.get", Category = InternalConstants.ApiCategoryUniqueName_System)]
    public class ContentGetRequest<TModel> : ContentRequest<TModel>
        where TModel : IContent
    {
        /// <summary>
        /// Gets or sets the content identifier.
        /// </summary>
        /// <value>
        /// The content identifier.
        /// </value>
        [ApiRequestParameter(required: true)]
        public int ID { get; set; }

        /// <summary>
        /// get or set the filter: FilterFieldsType 
        /// </summary>
        [ApiRequestParameter(required: true)]
        public int Fields { get; set; } = 1;
    }
}