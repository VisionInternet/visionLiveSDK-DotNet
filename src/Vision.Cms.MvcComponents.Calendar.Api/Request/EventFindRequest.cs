using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision.Api.Common;

namespace Vision.Cms.MvcComponents.Calendar.Api.Request
{
    [ApiName("cms.calendarcomponent.event.find",
            Category = InternalConstants.ApiCategoryUniqueName)]
    public class EventFindRequest : ApiRequest
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
        /// get or set the event StartDate
        /// NUll: ignore the filter
        /// </summary>
        [ApiRequestParameter(required: false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// get or set the event EndDate
        /// NUll: ignore the filter
        /// </summary>
        [ApiRequestParameter(required: false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// get or set the event title or subtitle
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
