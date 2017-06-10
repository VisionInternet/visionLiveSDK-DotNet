using Vision.Api.Common;

namespace Vision.Cms.MvcComponents.Calendar.Api.Request
{
    [ApiName("cms.calendarcomponent.eventlocation.get", Category = InternalConstants.ApiCategoryUniqueName)]
   public class EventLocationGetRequest : ApiRequest
    {
       /// <summary>
        /// get or set the filter: ID 
        /// ID is eventID
       /// </summary>
       [ApiRequestParameter(required: true)]
       public int ID { get; set; }

    }

}
