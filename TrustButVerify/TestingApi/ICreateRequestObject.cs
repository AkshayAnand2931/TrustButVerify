using RestSharp;
using TrustButVerify.Models;

namespace TrustButVerify.TestingApi
{
    public interface ICreateRequestObject
    {
        public RestClient CreateRestClient(RequestBody requestBody);
        public RestRequest CreateRestRequest(RequestBody requestBody);
        public RestRequest ConfigureQueryParameters(RequestBody requestBody, RestRequest restRequest);
        public RestRequest ConfigureUrlSegments(RequestBody requestBody, RestRequest restRequest);
        public string ConfigureUrl(RequestBody requestBody);
    }
}
