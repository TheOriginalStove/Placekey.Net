namespace Placekey.Api.Http;

public interface IHttpClient : IDisposable
{
    Task<IResponse> SendRequest(IRequest request);

    void SetRequestTimeout(TimeSpan timeout);
}
