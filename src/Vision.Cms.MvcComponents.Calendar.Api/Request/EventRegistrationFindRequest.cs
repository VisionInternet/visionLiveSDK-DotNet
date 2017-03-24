using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Vision.Api.Common;

namespace Vision.Cms.MvcComponents.Calendar.Api.Request
{
    [ApiName("cms.calendarcomponent.eventregistration.find",
            Category = InternalConstants.ApiCategoryUniqueName)]
    public class EventRegistrationFindRequest : ApiRequest
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
        /// Get or set the filter: Event ID
        /// NULL: ignore the filter;
        /// </summary>
        [ApiRequestParameter(required: false)]
        public int? EventID  { get; set; }

        /// <summary>
        /// Get or set submitted by. (Website User's email)
        /// </summary>
        [ApiRequestParameter(required: false)]
        public string SubmittedBy { get; set; }

        /// <summary>
        /// Get or set registration status
        /// 1. Pending
        /// 2. Confirmed
        /// 3. Cancelled
        /// </summary>
        [ApiRequestParameter(required: false)]
        public int? RegistrationStatus { get; set; }
    }
}
