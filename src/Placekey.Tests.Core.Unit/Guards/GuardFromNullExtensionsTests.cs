using Xunit;
using FluentAssertions;
using Placekey.Core;

namespace Placekey.Tests.Core.Unit;

public class GuardFromNullExtensionsTests
{
    [Fact]
    public void GuardFromNull_DoesNothing_NotNullValue()
    {
        //  Arrange
        var stringToTest = "";
        var intToTest = 1;
        var doubleToTest = 1.0;
        var dateTimeToTest = DateTime.Now;
        var objectToTest = new Object();

        // Act
        Action act1 = () => Guard.From.Null("", "string");
        Action act2 = () => Guard.From.Null(1, "int");
        Action act3 = () => Guard.From.Null(1.00, "double");
        Action act4 = () => Guard.From.Null(DateTime.Now, "datetime");
        Action act5 = () => Guard.From.Null(new Object(), "object");

        // Assert
        act1.Should().NotThrow<ArgumentNullException>();
        act2.Should().NotThrow<ArgumentNullException>();
        act3.Should().NotThrow<ArgumentNullException>();
        act4.Should().NotThrow<ArgumentNullException>();
        act5.Should().NotThrow<ArgumentNullException>();
    }

    [Fact]
    public void GuardFromNull_ThrowsException_DefaultMessage()
    {
        // Arrange
        string nullString = null;

        // Act
        Action act = () => Guard.From.Null(nullString, nameof(nullString));

        // Assert
        act.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    public void GuardFromNull_ThrowsException_CustomMessage()
    {
        // Arrange
        var customMessage = "These are not the droids you are looking for.";
        string nullString = null;

        // Act
        Action act = () => Guard.From.Null(nullString, nameof(nullString), customMessage);

        // Assert
        act.Should().Throw<ArgumentNullException>().Which.Message.Should().Contain(customMessage);
    }

    [Fact]
    public void GuardFromNullOrWhitespace_DoesNothing_NotNullOrWhitespace()
    {
        // Arrange
        string stringToTest = "Twenty points to Gryffindor!";

        // Act
        Action act = () => Guard.From.NullOrWhiteSpace(stringToTest, nameof(stringToTest));

        // Assert
        act.Should().NotThrow<ArgumentException>();
    }

    [Fact]
    public void GuardFromNullOrWhitespace_ShouldThrowArgumentException()
    {
        // Arrange
        string nullString = null;
        string whitespace = "";

        // Act
        Action act1 = () => Guard.From.NullOrWhitespace(nullString, nameof(nullString));
        Action act2 = () => Guard.From.NullOrWhitespace(whitespace, nameof(whitespace));

        // Assert
        act1.Should().Throw<ArgumentException>().Which.Message.Should().Contain("either null or whitespace");
        act2.Should().Throw<ArgumentException>().Which.Message.Should().Contain("either null or whitespace");
    }

    [Fact]
    public void GuardFromNullOrWhitespace_ShouldThrowArgumentException_WithCustomMessage()
    {

        // Arrange
        string nullString = null;
        string whitespace = "";
        var message = "NullArgumentException is a path to the dark side. Null leads to anger; anger leads to hate; hate leads to suffering.";

        // Act
        Action act1 = () => Guard.From.NullOrWhitespace(nullString, nameof(nullString), message);
        Action act2 = () => Guard.From.NullOrWhitespace(whitespace, nameof(whitespace), message);

        // Assert
        act1.Should().Throw<ArgumentException>().Which.Message.Should().Contain(message);
        act2.Should().Throw<ArgumentException>().Which.Message.Should().Contain(message);
    }

    [Fact]
    public void GuardFromNullOrEmpty_ShouldDoNothing()
    {
        // Arrange
        var testString = "Feel the force!";

        // Act
        Action act = () => Guard.From.NullOrEmpty(testString, nameof(testString));

        // Assert
        act.Should().NotThrow<ArgumentException>();
    }

    [Fact]
    public void GuardFromNullOrEmpty_ShouldThrowException()
    {
        // Arrange
        string nullString = null;
        var empty = "";

        // Act
        Action act1 = () => Guard.From.NullOrEmpty(nullString, nameof(nullString));
        Action act2 = () => Guard.From.NullOrEmpty(empty, nameof(empty));

        // Assert
        act1.Should().Throw<ArgumentException>().Which.Message.Should().Contain("either null or empty");
        act2.Should().Throw<ArgumentException>().Which.Message.Should().Contain("either null or empty");
    }

    [Fact]
    public void GuardFromNullOrEmpty_ShouldThrowException_WithCustomMessage()
    {
        // Arrange
        string nullString = null;
        var empty = "";
        var message = "Always pass on what you have learned";

        // Act
        Action act1 = () => Guard.From.NullOrEmpty(nullString, nameof(nullString), message);
        Action act2 = () => Guard.From.NullOrEmpty(empty, nameof(empty), message);

        // Assert
        act1.Should().Throw<ArgumentException>().Which.Message.Should().Contain(message);
        act2.Should().Throw<ArgumentException>().Which.Message.Should().Contain(message);
    }


}
