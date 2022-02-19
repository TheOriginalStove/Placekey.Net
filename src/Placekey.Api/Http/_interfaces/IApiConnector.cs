namespace Placekey.Api.Http;

public interface IApiConnector
{
    event EventHandler<IResponse>? ResponseReceived;

    Task<T> Post<T>(Uri uri, IDictionary<string, string>? parameters, object? body);

    Task<T> Post<T>(Uri uri, IDictionary<string, string>? parameters, object? body,
        IDictionary<string, string>? headers);

    Task<T> SendRequest<T>(Uri uri, HttpMethod method, IDictionary<string, string>? parameters = null,
        object? body = null, IDictionary<string, string>? headers = null);

    void SetRequestTimeout(TimeSpan timeout);

}
