using Placekey.Api.Models;

namespace Placekey.Api;

public interface IPlacekeyClient
{
    Task<PlacekeyResponse> GetPlacekey(IPlacekeyRequest request);

    Task<PlacekeyResponse> GetPlacekeys(IPlacekeyRequest request);
}
