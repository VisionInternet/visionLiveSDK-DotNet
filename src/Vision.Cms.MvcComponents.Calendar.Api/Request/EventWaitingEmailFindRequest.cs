using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Vision.Api.Common;

namespace Vision.Cms.MvcComponents.Calendar.Api.Request
{
    [ApiName("cms.calendarcomponent.eventwaitingemail.find",
            Category = InternalConstants.ApiCategoryUniqueName)]
    public class EventWaitingEmailFindRequest : ApiRequest
    {
        /// <summary>
        /// Get or set the page index(from 1)
        /// </summary>
        [ApiRequestParameter]
        [Range(1,int.MaxValue)]
        public int PageIndex { get; set; }

        /// <summary>
        /// Get or set the page size
        /// </summary>
        [ApiRequestParameter]
        [Range(1, ApiConstant.MaxPageSize)]
        public int PageSize { get; set; }

        /// <summary>
        /// Get or set the filter: event id
        /// NULL: ignore the filter;
        /// </summary>
        [ApiRequestParameter(required: false)]
        public int? EventID { get; set; }

        /// <summary>
        /// Get or set the filter: whether is sent or not.
        /// NULL: ignore the filter;
        /// </summary>
        [ApiRequestParameter(required: false)]
        public bool? IsSent { get; set; }

        /// <summary>
        /// Get or set the filter: submitted by (website user's email)
        /// NULL: ignore the filter;
        /// </summary>
        [ApiRequestParameter(required:false)]
        public string SubmittedBy { get; set; }
    }
}
