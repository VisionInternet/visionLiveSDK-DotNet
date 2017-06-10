using System.ComponentModel.DataAnnotations;
using Vision.Api.Common;
using Vision.Api.Common.Request;
using Vision.Cms.Mvc.Api.Domain;

namespace Vision.Cms.Mvc.Api.Request
{
    /// <summary>
    /// Content find request
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    /// <seealso cref="Vision.Cms.Mvc.Api.Request.ContentRequest{TModel}" />
    [ApiName("cms.core.system.content.find", Category = InternalConstants.ApiCategoryUniqueName_System)]
    public class ContentFindRequest<TModel> : ContentRequest<TModel>
        where TModel : IContent
    {
        /// <summary>
        /// get or set the page index(from 1)
        /// </summary>
        [ApiRequestParameter]
        [Range(1, int.MaxValue)]
        public int PageIndex { get; set; }

        /// <summary>
        /// get or set the page size
        /// </summary>
        [ApiRequestParameter]
        [Range(1, ApiConstant.MaxPageSize)]
        public int PageSize { get; set; }

        /// <summary>
        /// get or set the content title or subtitle
        /// NUll: ignore the filter
        /// </summary>
        [ApiRequestParameter(required: true)]
        public string Filter { get; set; }

        /// <summary>
        /// get or set the category filters (concat with IDs), e.g. 1,2,3
        /// </summary>
        [ApiRequestParameter]
        public string CategoryIDsConstraint { get; set; }

        /// <summary>
        /// get or set the department filters (concat with IDs), e.g. 1,2,3
        /// </summary>
        [ApiRequestParameter]
        public string DepartmentIDsConstraint { get; set; }
    }
}