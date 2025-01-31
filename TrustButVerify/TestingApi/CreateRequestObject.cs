using RestSharp;
using TrustButVerify.Models;

namespace TrustButVerify.TestingApi
{
    public class CreateRequestObject : ICreateRequestObject
    {
        public RestRequest ConfigureQueryParameters(RequestBody requestBody, RestRequest restRequest)
        {
            throw new NotImplementedException();
        }

        public string ConfigureUrl(RequestBody requestBody)
        {
            throw new NotImplementedException();
        }

        public RestRequest ConfigureUrlSegments(RequestBody requestBody, RestRequest restRequest)
        {
            throw new NotImplementedException();
        }

        public RestClient CreateRestClient(RequestBody requestBody)
        {
            throw new NotImplementedException();
        }

        public RestRequest CreateRestRequest(RequestBody requestBody)
        {
            throw new NotImplementedException();
        }
    }
}
