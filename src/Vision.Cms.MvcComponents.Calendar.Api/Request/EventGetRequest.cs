using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision.Api.Common;

namespace Vision.Cms.MvcComponents.Calendar.Api.Request
{
   [ApiName("cms.calendarcomponent.event.get",
            Category = InternalConstants.ApiCategoryUniqueName)]
   public class EventGetRequest : ApiRequest
    {
       /// <summary>
        /// get or set the filter: ID 
        /// ID is eventID
       /// </summary>
       [ApiRequestParameter(required: true)]
       public int ID { get; set; }

       /// <summary>
       /// get or set the filter: Fields 
       /// 
       /// 1 is Basic field,include title, subtitle etc.
       /// 2 is event Content field
       /// 4 is event Document field
       /// 8 is event RegistrationSetting field
       /// 16 is event Category field
       /// 32 is event Department field
       /// 64 is event ContentReview field
       /// 128 is event MemberGroup field
       /// </summary>
       [ApiRequestParameter(required: true)]
       public int Fields { get; set; }
    }

   [Flags]
   public enum FieldsType 
   {
      Basic = 1,
      Content = 2,
      EventDocument = 4,
      RegistrationSetting = 8,
      Category = 16,
      Department = 32,
      CustomReview = 64,
      Member = 128
   }
}
