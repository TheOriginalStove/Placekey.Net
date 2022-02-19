namespace Placekey.Api;

public interface ILineageClient
{
    Task<LineageResponse> GetLineages(ILineageRequest request);
}
