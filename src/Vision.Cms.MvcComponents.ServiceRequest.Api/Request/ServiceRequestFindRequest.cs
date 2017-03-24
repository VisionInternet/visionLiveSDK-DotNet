using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision.Api.Common;
using System.ComponentModel.DataAnnotations;

namespace Vision.Cms.MvcComponents.ServiceRequest.Api.Request
{
    [ApiName("cms.servicerequestscomponent.servicerequest.find", 
        Category = InternalConstants.ApiCategoryUniqueName)]
    public class ServiceRequestFindRequest : ApiRequest
    {
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

        /// <summary>
        /// Get or set the sort name 
        /// Only supports fields 'Subject', 'Status', 'Topic', 'ReportedDate'
        /// </summary>
        [ApiRequestParameter]
        public string SortBy { get; set; }

        /// <summary>
        /// Get or set the sort direction
        /// </summary>
        [ApiRequestParameter]
        public bool Ascending { get; set; }

        [ApiRequestParameter]
        public DateTime? StartDate { get; set; }

        [ApiRequestParameter]
        public DateTime? EndDate { get; set; }

        [ApiRequestParameter]
        public string ReportedBy { get; set; }

        [ApiRequestParameter]
        public string ToProcessor { get; set; }

        [ApiRequestParameter]
        public string Topic { get; set; }
    }
}
