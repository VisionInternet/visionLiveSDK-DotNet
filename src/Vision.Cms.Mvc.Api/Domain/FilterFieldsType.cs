using System;

namespace Vision.Cms.Mvc.Api.Domain
{
    [Flags]
    public enum FilterFieldsType
    {
        Basic = 1,
        Content = 2,
        Category = 4,
        Department = 8,
        CustomReview = 16,
        Member = 32,
        Tag = 64
    }
}
