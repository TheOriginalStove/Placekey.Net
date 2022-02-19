namespace Placekey.Api;

public interface IApiClient
{
    /// <summary>
    /// Operations related to grabbing placekeys
    /// </summary>
    IPlacekeyClient Placekey { get; }

    ILineageClient Lineage { get; }

}
