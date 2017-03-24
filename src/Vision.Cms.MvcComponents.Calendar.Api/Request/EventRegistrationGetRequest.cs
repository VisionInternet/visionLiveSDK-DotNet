using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Vision.Api.Common;

namespace Vision.Cms.MvcComponents.Calendar.Api.Request
{
    [ApiName("cms.calendarcomponent.eventregistration.get",
            Category = InternalConstants.ApiCategoryUniqueName)]
    public class EventRegistrationGetRequest : ApiRequest
    {
        /// <summary>
        /// Get or set the filter: Registration ID
        /// NULL: ignore the filter;
        /// </summary>
        [ApiRequestParameter(required: false)]
        public int? RegistrationID  { get; set; }

        /// <summary>
        /// Get or set the filter: GUID
        /// NULL: ignore the filter;
        /// </summary>
        [ApiRequestParameter(required:false)]
        public Guid? GUID { get; set; }
    }
}
