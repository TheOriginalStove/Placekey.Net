using Placekey.Api.Extensions;

namespace Placekey.Tests.Api.Unit.Extensions;

public class UriExtensionsTests
{
    [Fact(Skip = "does nothing yet")]
    public void ApplyParameters_AddsParameters()
    {
        // Arrange
        var url = new Uri("https://example.com");
        var queryParams = new Dictionary<string, string> {{"id", "12345"}};

        // Act

        url.ApplyParameters(queryParams);

        // Assert
        url.Query.Should().Contain("id=12345");
    }

}
