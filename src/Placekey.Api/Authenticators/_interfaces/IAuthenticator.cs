using System.Threading.Tasks;
using Placekey.Api.Http;

namespace Placekey.Api.Authentication
{
    public interface IAuthenticator
    {
        Task Apply(IRequest request, IApiConnector apiConnector);
    }
}
