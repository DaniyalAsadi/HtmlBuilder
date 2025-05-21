namespace HtmlBuilder.Enums;
/// <summary>
/// Provides extension methods for the <see cref="FormMethod"/> enumeration to facilitate working with HTML form
/// attributes.
/// </summary>
/// <remarks>This class includes methods to convert <see cref="FormMethod"/> values to their corresponding HTML
/// string representations, enabling seamless integration with HTML form generation.</remarks>
internal static class FormMethodExtensions
{
    /// <summary>
    /// Converts the specified <see cref="FormMethod"/> value to its corresponding HTML string representation.
    /// </summary>
    /// <param name="method">The <see cref="FormMethod"/> value to convert.</param>
    /// <returns>A string representing the HTML form method attribute value. Returns <see langword="get"/> for <see
    /// cref="FormMethod.Get"/>  and <see langword="post"/> for <see cref="FormMethod.Post"/>.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the <paramref name="method"/> value is not a valid <see cref="FormMethod"/> enumeration value.</exception>
    public static string ToHtmlString(this FormMethod method)
    {
        return method switch
        {
            FormMethod.Get => "get",
            FormMethod.Post => "post",
            _ => throw new ArgumentOutOfRangeException(nameof(method), method, null)
        };
    }
}
