using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision.Api.Common;

namespace Vision.Cms.MvcComponents.ServiceRequest.Api.Request
{
    [ApiName("cms.servicerequestscomponent.servicerequestcategory.find", 
        Category = InternalConstants.ApiCategoryUniqueName)]
    public class ServiceRequestCategoryFindRequest : ApiRequest
    {
        /// <summary>
        /// Get or set the page index(from 1)
        /// </summary>
        [ApiRequestParameter]
        public int PageIndex { get; set; }

        /// <summary>
        /// Get or set the page size
        /// </summary>
        [ApiRequestParameter]
        public int PageSize { get; set; }
    }
}
