using Newtonsoft.Json.Linq;

namespace TrustButVerify.Models
{
    public class RequestBody
    {
        public required string RequestUrl { get; init; }
        public Dictionary<string,string?>? QueryParameters { get; init; }
        public Dictionary<string,string?>? UrlSegments { get; init; }
        public string? Payload { get; init; }

    }
}
