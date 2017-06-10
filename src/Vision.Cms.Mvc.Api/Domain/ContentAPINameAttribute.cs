using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Cms.Mvc.Api.Domain
{
    public class ContentAPINameAttribute : Attribute
    {
        #region Ctors
        public ContentAPINameAttribute(string name)
        {
            Name = name;
        }
        #endregion

        #region Properties
        public string Name { get; private set; }
        #endregion

        #region Content Type Name Constants
        public const string News = "News";
        public const string Rfp = "RFP";
        public const string Calendar = "Event";
        public const string BusinessDirectory = "BusinessDirectory";
        public const string FacilityDirectory = "FacilityDirectory";
        public const string FAQ = "FAQ";
        public const string Forms = "Form";
        public const string MeetingItem = "MeetingItem";
        public const string MeetingAgenda = "MeetingAgenda";
        public const string MeetingMinutes = "MeetingMinutes";
        public const string JobPosts = "Job";
        public const string OnlinePolls = "OnlinePolls";
        public const string PhotoAlbum = "PhotoAlbum";
        public const string ServiceDirectory = "ServiceDirectory";
        public const string StaffDirectory = "StaffDirectory";
        #endregion
    }
}
