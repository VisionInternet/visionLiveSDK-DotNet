using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision.Api.Common;

namespace Vision.Cms.MvcComponents.ServiceRequest.Api.Request
{
    [ApiName("cms.servicerequestscomponent.servicerequestpost.find", 
        Category = InternalConstants.ApiCategoryUniqueName)]
    public class ServiceRequestPostFindRequest : ApiRequest
    {
        /// <summary>
        /// Get or set the service request ID of post and this property is required.
        /// </summary>
        [ApiRequestParameter]
        public int ServiceRequestID { get; set; }

        /// <summary>
        /// Get of set the email of post, this property is optional.
        /// </summary>
        [ApiRequestParameter]
        public string PostedBy { get; set; }

        /// <summary>
        /// Get of set the post start dat, this property is optional.
        /// </summary>
        [ApiRequestParameter]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Get of set the post end dat, this property is optional.
        /// </summary>
        [ApiRequestParameter]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Get of set the flag which indicates the post is internal or not, this property is optional.
        /// </summary>
        [ApiRequestParameter]
        public bool? Internal { get; set; }
        /// <summary>
        /// Get or set the page index(from 1)
        /// </summary>
        [ApiRequestParameter]
        [Range(1, int.MaxValue)]
        public int PageIndex { get; set; }

        /// <summary>
        /// Get or set the page size
        /// </summary>
        [ApiRequestParameter]
        [Range(1, ApiConstant.MaxPageSize)]
        public int PageSize { get; set; }
    }
}
