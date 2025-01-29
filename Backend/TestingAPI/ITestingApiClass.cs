using RestSharp;
using TrustButVerify.Models;

namespace TrustButVerify.TestingAPI
{
    public interface ITestingApiClass
    {
        RestClient CreateRestClient(RequestBody requestBody);
        RestRequest CreateRestRequest(RequestBody requestBody);
        Task<RestResponse> TestAPIUrl(RequestBody requestBody);
    }
}