namespace HtmlBuilder.Enums;
/// <summary>
/// Provides extension methods for the <see cref="FormEncryptType"/> enumeration.
/// </summary>
/// <remarks>This class includes methods to convert <see cref="FormEncryptType"/> values to their corresponding
/// representations, such as HTML content type strings.</remarks>
internal static class FormEncryptTypeExtensions
{
    /// <summary>
    /// Converts the specified <see cref="FormEncryptType"/> value to its corresponding HTML content type string.
    /// </summary>
    /// <param name="encryptType">The <see cref="FormEncryptType"/> value to convert.</param>
    /// <returns>A string representing the HTML content type associated with the specified <see cref="FormEncryptType"/>. For
    /// example, "application/x-www-form-urlencoded" for <see cref="FormEncryptType.UrlEncoded"/>.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the <paramref name="encryptType"/> value is not a valid <see cref="FormEncryptType"/>.</exception>
    public static string ToHtmlString(this FormEncryptType encryptType)
    {
        return encryptType switch
        {
            FormEncryptType.UrlEncoded => "application/x-www-form-urlencoded",
            FormEncryptType.Multipart => "multipart/form-data",
            FormEncryptType.PlainText => "text/plain",
            _ => throw new ArgumentOutOfRangeException(nameof(encryptType), encryptType, null)
        };
    }
}
