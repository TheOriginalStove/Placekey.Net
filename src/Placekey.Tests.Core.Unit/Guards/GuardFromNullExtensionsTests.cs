using System;
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

}
