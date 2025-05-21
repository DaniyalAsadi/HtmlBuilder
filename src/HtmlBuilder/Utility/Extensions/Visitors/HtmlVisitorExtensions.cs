using HtmlBuilder.Visitors;

namespace HtmlBuilder.Utility.Extensions.Visitors;
/// <summary>
/// Provides extension methods for rendering <see cref="IHtmlElement"/> objects into HTML strings.
/// </summary>
/// <remarks>This class includes methods for converting HTML elements into formatted or minimal HTML string
/// representations. These methods are useful for scenarios such as debugging, displaying human-readable HTML, or
/// generating compact HTML output.</remarks>
public static class HtmlVisitorExtensions
{
    /// <summary>
    /// Converts the specified HTML element into a well-formatted, indented HTML string.
    /// </summary>
    /// <remarks>This method uses a renderer to produce a human-readable HTML string with proper indentation,
    /// making it suitable for debugging or displaying HTML in a readable format.</remarks>
    /// <param name="htmlElement">The HTML element to render as a formatted HTML string. Cannot be <see langword="null"/>.</param>
    /// <returns>A string containing the formatted HTML representation of the specified element.</returns>
    public static string ToPrettyHtml(this IHtmlElement htmlElement)
    {
        IHtmlRenderer renderer = new PrettyHtmlRenderer();

        return renderer.Render(htmlElement);
    }
    /// <summary>
    /// Converts the specified <see cref="IHtmlElement"/> to a minimal HTML string representation.
    /// </summary>
    /// <remarks>This method uses a minimal HTML rendering strategy to produce a compact representation of the
    /// HTML element.</remarks>
    /// <param name="htmlElement">The HTML element to convert. Must not be <see langword="null"/>.</param>
    /// <returns>A string containing the minimal HTML representation of the specified <see cref="IHtmlElement"/>.</returns>
    public static string ToMinimalHtml(this IHtmlElement htmlElement)
    {
        IHtmlRenderer renderer = new MinimalHtmlRenderer();
        return renderer.Render(htmlElement);
    }
}
