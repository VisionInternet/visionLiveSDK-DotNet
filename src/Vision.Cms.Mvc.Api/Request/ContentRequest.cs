using Vision.Api.Common;
using Vision.Api.Common.Request;
using Vision.Cms.Mvc.Api.Domain;

namespace Vision.Cms.Mvc.Api.Request
{
    /// <summary>
    /// API content request model.
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    /// <seealso cref="Vision.Api.Common.ApiRequest" />
    [GenericRequestTypePropertyDependencyAttribute(ApiContentConstants.ContentTypeNamePropertyName)]
    [GenericRequestTypeFactory(typeof(ContentGenericRequestTypeFactory))]
    public abstract class ContentRequest<TModel> : ApiRequest
        where TModel : IContent
    {
        /// <summary>
        /// Gets or sets the name of the content type.
        /// </summary>
        /// <value>
        /// The name of the content type.
        /// </value>
        [ApiRequestParameter(required: true)]
        public string ContentTypeName { get; set; }
    }
}