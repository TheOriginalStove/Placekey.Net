using System.Threading.Tasks;

namespace Placekey.Api.Authentication
{
    public interface IAuthenticator
    {
        Task Apply(IRequest request, IApiConnector apiConnector);
    }
}
