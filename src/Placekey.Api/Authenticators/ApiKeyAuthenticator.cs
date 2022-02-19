using System.Threading.Tasks;
using Placekey.Api;
using Placekey.Api.Http;
using Placekey.Core.Guards;

namespace Placekey.Api.Authentication
{
    public class ApiKeyAuthenticator : IAuthenticator
    {
        public string ApiKey { get; set; }

        public ApiKeyAuthenticator(string apiKey)
        {
            ApiKey = apiKey;
        }

        public Task Apply(IRequest request, IApiConnector apiConnector)
        {
            Guard.From.Null(request, nameof(request));

            // Per Placekey API documentation, the token provided through the developer dashboard
            // to be passed via the header as "apiKey" : "{{YourApiKey}}"
            request.Headers["apiKey"] = $"{ApiKey}";
            return Task.CompletedTask;
        }

    }

}
