using RestSharp;
using TrustButVerify.Models;
using TrustButVerify.Exceptions;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace TrustButVerify.TestingAPI
{
    public class TestingEndpoint : ITestingEndpoint
    {
        public async Task<RestResponse> TestAPIEndpoint(RequestBody requestBody)
        {
            RestClient client = CreateRestClient(requestBody);
            RestRequest restRequest = CreateRestRequest(requestBody);

            RestResponse restResponse = await client.ExecuteAsync(restRequest);

            if(restResponse != null)
            {
                return restResponse;
            }
            throw new RequestNullException("The response was null.");
        }

        public RestClient CreateRestClient(RequestBody requestBody)
        {
            //Handle different methods

            RestClientOptions restClientOptions = new RestClientOptions(requestBody.RequestUrl);
            RestClient restClient = new RestClient(restClientOptions);

            return restClient;
        }

        public RestRequest CreateRestRequest(RequestBody requestBody)
        {
            //break into seperate functions

            RestRequest restRequest = new RestRequest();
            
            if(requestBody.QueryParameters != null)
            {
                foreach(KeyValuePair<string,string?> pair in requestBody.QueryParameters)
                {
                    if(pair.Value != null)
                    {
                        restRequest.AddQueryParameter(pair.Key, pair.Value);
                    }
                }
            }

            if(requestBody.UrlSegments != null)
            {
                foreach(KeyValuePair<string,string?> pair in requestBody.UrlSegments)
                {
                    if(pair.Value != null)
                    {
                        restRequest.AddUrlSegment(pair.Key, pair.Value);
                    }
                    else
                    {
                        //remove the url segment from the url
                    }    
                    
                }
            }

            if(requestBody.Payload != null)
            {
                restRequest.AddStringBody(requestBody.Payload.ToString(), ContentType.Json);
            }

            return restRequest;
        }
    }
}
