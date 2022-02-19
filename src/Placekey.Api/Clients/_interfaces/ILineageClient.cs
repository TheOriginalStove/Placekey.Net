
namespace Placekey.Api;

public interface ILineageClient
{
    Task<ILineageResponse> GetLineages(ILineageRequest request);
}
