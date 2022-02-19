namespace Placekey.Api.Models;

/// <summary>
/// The api key to access the Placekey API endpoints (provided by Placekey Developer Dashboard)
/// </summary>
public interface IApiKey
{
    public string Value { get; set; }
}
