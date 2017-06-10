using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vision.Api.Common;
using Vision.Cms.MvcComponents.Calendar.Api.Request;
using Vision.Cms.MvcComponents.Calendar.Api.Response;

namespace Vision.Api.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new JSONApiClient("http://www.city.gov/API", "*********", "*************");
            var request = new EventGetRequest();
            request.ID = 1;
            request.Fields = 1;
            var response = client.Execute<EventGetRequest, EventGetResponse>(request);
        }
    }
}
