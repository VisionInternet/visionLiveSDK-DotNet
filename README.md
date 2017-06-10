# visionLiveAPIDotNetSDK
The DotNet SDK project for visionLive API

API Explorer: http://api.visioninternet.com/

API Document: http://api.visioninternet.com/Document

C# Example:
```
var client = new JSONApiClient("http://www.city.gov/API", "{App Key}", "{App Secret}");
var request = new EventGetRequest();
request.ID = 5577;
request.Fields = 1;
var response = client.Execute<EventGetRequest,EventGetResponse>(request);
```
