using System.Threading.Tasks;
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
            Guard.Against.Null(request, nameof(request));


        }

    }

}
