namespace Placekey.Api.Http;

public interface IProxyConfig
{
   string Host { get; }

   int Port { get; }

   bool SkipSslCheck { get; }

   bool BypassProxyOnLocal { get; }

   string? User { get; }

   string? Password { get; }
}
