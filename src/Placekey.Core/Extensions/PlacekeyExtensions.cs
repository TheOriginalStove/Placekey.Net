namespace Placekey.Core.Extensions;

public static partial class PlacekeyExtensions
{
    /// <summary>
    /// Convert the Placekey to lat and lng coordinates returned as a tuple.
    /// </summary>
    /// <param name="placekey"></param>
    /// <returns>(double latitude, double longitude)</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static (double, double) ToGeolocation(this IPlacekey placekey)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Convert the Placekey to GeoLocation
    /// </summary>
    /// <param name="placekey"></param>
    /// <typeparam name="IGeoLocation"></typeparam>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static IGeoLocation ToGeoLocation(this IPlacekey placekey)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Convert the Placekey to an H3 Integer
    /// </summary>
    /// <param name="placekey"></param>
    /// <returns>H3 Index</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static int ToH3Integer(this IPlacekey placekey)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Return an unordered list of Placekeys whose grid distance is less than or equal to distance from the given Placekey.
    /// For this context grid distance refers to the number of H3 cells between two H3 cells.
    /// Neighboring cells have a distance of 1. Neighbors of neighbors have a distance of 2, etc.
    /// </summary>
    /// <param name="placekey"></param>
    /// <param name="distance"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static List<IPlacekey> GetNeighboringPlacekeys(this IPlacekey placekey, int distance = 1)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get the boundary shape Polygon from Placekey
    /// </summary>
    /// <param name="placekey"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static IPolygon ToPolygon(this IPlacekey placekey)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Convert the Placekey into the WKT (Well-Known-Text) string for the corresponding hexagon. Coordinates are (longitude, latitude).
    /// </summary>
    /// <param name="placekey"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static string ToWKT(this IPlacekey placekey)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Convert a Placekey into a GeoJSON dictionary.
    /// </summary>
    /// <param name="placekey"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static string ToGeoJson(this IPlacekey placekey)
    {
        throw new NotImplementedException();
    }

    #region privateMethods

    #endregion


}
