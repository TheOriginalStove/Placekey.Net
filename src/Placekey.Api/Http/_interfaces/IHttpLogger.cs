namespace Placekey.Api.Http;

public interface IHttpLogger
{
    void OnRequest(IRequest request);

    void OnResponse(IResponse response);
}
