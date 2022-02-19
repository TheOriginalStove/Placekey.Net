using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;

namespace Placekey.Api.Http;

public interface IApiResponse<out T>
{
    [MaybeNull, AllowNull]
    T Body { get; }

    IResponse Response { get; }
}
