namespace HtmlBuilder.Enums;
/// <summary>
/// Provides extension methods for the <see cref="InputType"/> enumeration, enabling conversion to HTML-compatible
/// string representations.
/// </summary>
/// <remarks>This class contains methods that simplify working with <see cref="InputType"/> values by converting
/// them to their corresponding HTML input type attribute values. These methods are particularly useful when dynamically
/// generating HTML forms or elements.</remarks>
internal static class InputTypeExtensions
{
    /// <summary>
    /// Converts the specified <see cref="InputType"/> value to its corresponding HTML string representation.
    /// </summary>
    /// <param name="inputType">The <see cref="InputType"/> value to convert.</param>
    /// <returns>A string representing the HTML input type attribute value corresponding to the specified <paramref
    /// name="inputType"/>.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the specified <paramref name="inputType"/> is not a valid <see cref="InputType"/> value.</exception>
    public static string ToHtmlString(this InputType inputType)
    {
        return inputType switch
        {
            InputType.Text => "text",
            InputType.Password => "password",
            InputType.Email => "email",
            InputType.Number => "number",
            InputType.Date => "date",
            InputType.Color => "color",
            InputType.Range => "range",
            InputType.Checkbox => "checkbox",
            InputType.Radio => "radio",
            InputType.File => "file",
            InputType.Button => "button",
            InputType.Submit => "submit",
            InputType.Reset => "reset",
            InputType.Image => "image",
            InputType.Hidden => "hidden",
            InputType.Search => "search",
            InputType.DatetimeLocal => "datetime-local",
            InputType.Month => "month",
            InputType.Time => "time",
            InputType.Url => "url",
            InputType.Tel => "tel",
            InputType.Week => "week",
            _ => throw new ArgumentOutOfRangeException(nameof(inputType), inputType, null)
        };
    }
}
