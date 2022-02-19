namespace Placekey.Api.Http;

public interface IJsonSerializer
{
    void SerializeRequest(IRequest request);

    IApiResponse<T> DeserializeResponse<T>(IResponse response);
}
