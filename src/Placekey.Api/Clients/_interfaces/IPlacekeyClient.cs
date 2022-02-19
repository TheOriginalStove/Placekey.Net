using Placekey.Api.Models;

namespace Placekey.Api;

public interface IPlacekeyClient
{
    Task<IPlacekeyResponse> GetPlacekey(IPlacekeyRequest request);

    Task<IPlacekeyResponse> GetPlacekeys(IPlacekeyRequest request);
}
