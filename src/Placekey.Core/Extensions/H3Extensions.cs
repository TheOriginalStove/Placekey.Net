namespace Placekey.Core.Extensions;

public static partial class PlacekeyExtensions
{
    /// <summary>
    /// Convert an H3 Hexadeximal into a Placekey string.
    /// </summary>
    /// <param name="h3index"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static IPlacekey H3ToPlacekey(this IH3Index h3index)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Convert an H3 Integer into a Placekey
    /// </summary>
    /// <param name="h3index"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static IPlacekey H3IndexToPlacekey(this int h3index)
    {
        throw new NotImplementedException();
    }

}

public class IH3Index
{
}
