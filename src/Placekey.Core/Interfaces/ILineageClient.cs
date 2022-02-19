namespace Placekey.Core;

public interface ILineageClient
{
    Task<LineageResponse> GetLineages(ILineageRequest request);
}
