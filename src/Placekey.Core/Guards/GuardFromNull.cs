namespace Placekey.Core.Guards;

public static partial class GuardExtensions
{
    /// <summary>
    /// Verifies that an argument is not null
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static T Null<T>(this IGuard guard, T input, string parameterName, string? message = null)
    {
        if (input is null)
        {
            throw new ArgumentNullException(message ?? $"Required input {parameterName} was null", parameterName);
        }
        return input;
    }

    /// <summary>
    /// Verifies that an argument string is not null or whitespace
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static string NullOrWhitespace(this IGuard guard, string input, string parameterName,
        string? message = null)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentException(message ?? $"Required input {parameterName} was either null or whitespace", parameterName);
        }

        return input;
    }

    /// <summary>
    /// Verifies a string argument isn't empty or null
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static string NullOrEmpty(this IGuard guard, string input, string parameterName,
        string? message = null)
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentException(message ?? $"Required input {parameterName} was either null or empty", parameterName);
        }

        return input;
    }

    /// <summary>
    /// Verifies that an enumerable argument isn't empty or null
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static IEnumerable<T> NullOrEmptyEnumerable<T>(this IGuard guard, IEnumerable<T> input, string parameterName,
        string? message = null)
    {
        if (input is null && !input.Any())
        {
            throw new ArgumentException(message ?? $"Required input list {parameterName} is empty or null",
                parameterName);
        }

        return input;
    }

}
