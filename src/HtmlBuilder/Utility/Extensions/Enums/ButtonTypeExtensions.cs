namespace HtmlBuilder.Enums;
/// <summary>
/// Provides extension methods for the <see cref="ButtonType"/> enumeration.
/// </summary>
/// <remarks>This class includes methods to facilitate working with <see cref="ButtonType"/> values, such as
/// converting them to their corresponding HTML string representations.</remarks>
internal static class ButtonTypeExtensions
{
    /// <summary>
    /// Converts the specified <see cref="ButtonType"/> value to its corresponding HTML string representation.
    /// </summary>
    /// <param name="buttonType">The <see cref="ButtonType"/> value to convert.</param>
    /// <returns>A string representing the HTML value of the button type. Possible values are  <see langword="button"/>, <see
    /// langword="submit"/>, <see langword="reset"/>, or <see langword="menu"/>.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the <paramref name="buttonType"/> value is not a valid <see cref="ButtonType"/>.</exception>
    public static string ToHtmlString(this ButtonType buttonType)
    {
        return buttonType switch
        {
            ButtonType.Button => "button",
            ButtonType.Submit => "submit",
            ButtonType.Reset => "reset",
            ButtonType.Menu => "menu",
            _ => throw new ArgumentOutOfRangeException(nameof(buttonType), buttonType, null)
        };
    }
}
