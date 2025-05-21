using System;

namespace HtmlBuilder.Tags.TextContentTag;
/// <summary>
/// Provides extension methods for working with <see cref="DoubleHtmlElementWithChildren"/> objects, enabling the
/// addition and customization of <see cref="Figure"/> elements.
/// </summary>
/// <remarks>The <see cref="FigureExtensions"/> class contains methods that simplify the creation and
/// configuration of <see cref="Figure"/> elements within an HTML structure. These methods allow developers to
/// dynamically construct and append <see cref="Figure"/> elements to a parent <see
/// cref="DoubleHtmlElementWithChildren"/>  while supporting method chaining for fluent API usage.</remarks>
public static class FigureExtensions
{
    /// <summary>
    /// Adds a <see cref="Figure"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Figure"/> element through the provided action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Figure"/> element, applies the specified configuration
    /// action to it,  and appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>.  Use this
    /// method to dynamically construct and configure a <see cref="Figure"/> element within an HTML structure.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Figure"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <see cref="Figure"/> element before it is added as a
    /// child.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Figure(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Figure> action)
    {
        Figure tag = new Figure();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
