using Microsoft.AspNetCore.Mvc;
using RestSharp;
using TrustButVerify.TestingAPI;
using TrustButVerify.Models;

namespace TrustButVerify.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class TestingController : ControllerBase
    {
        private readonly ILogger<TestingController> _logger;
        private readonly TestingApiClass _testingAPI;

        public TestingController(ILogger<TestingController> logger, ITestingApiClass testingAPI)
        {
            _logger = logger;
            _testingAPI = (TestingApiClass)testingAPI;
        }

        [HttpPost()]
        public async Task<string?> TestEndpoint([FromBody]RequestBody requestBody)
        {
            RestResponse restResponse = await _testingAPI.TestAPIUrl(requestBody);
            return restResponse.Content;
        }
    }
}
