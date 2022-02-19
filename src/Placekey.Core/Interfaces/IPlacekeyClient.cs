namespace Placekey.Core;

public interface IPlacekeyClient
{
    Task<IPlacekeyResponse> GetPlacekey(IPlacekeyRequest request);

    Task<IPlacekeyResponse> GetPlacekeys()
}
