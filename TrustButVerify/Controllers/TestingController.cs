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
        private readonly TestingEndpoint _testingAPI;

        public TestingController(ILogger<TestingController> logger, ITestingEndpoint testingAPI)
        {
            _logger = logger;
            _testingAPI = (TestingEndpoint)testingAPI;
        }

        [HttpPost()]
        public async Task<string?> TestEndpoint([FromBody]RequestBody requestBody)
        {
            RestResponse restResponse = await _testingAPI.TestAPIEndpoint(requestBody);
            return restResponse.Content;
        }
    }
}
