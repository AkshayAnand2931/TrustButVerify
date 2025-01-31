using RestSharp;
using TrustButVerify.Models;

namespace TrustButVerify.TestingAPI
{
    public interface ITestingEndpoint
    {
        Task<RestResponse> TestAPIEndpoint(RequestBody requestBody);
    }
}