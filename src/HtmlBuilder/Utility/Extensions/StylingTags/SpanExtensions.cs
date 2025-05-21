using System;

namespace HtmlBuilder.Tags.StylingTags;
/// <summary>
/// Provides extension methods for working with HTML elements, enabling the addition and customization of <see
/// cref="Span"/> elements.
/// </summary>
/// <remarks>The <see cref="SpanExtensions"/> class contains methods that simplify the creation and configuration
/// of <see cref="Span"/> elements within a parent <see cref="DoubleHtmlElementWithChildren"/>. These methods support
/// fluent method chaining for building HTML structures.</remarks>
public static class SpanExtensions
{
    /// <summary>
    /// Adds a <see cref="Span"/> element as a child to the current HTML element and allows customization of the <see
    /// cref="Span"/> element.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Span"/> element, applies the specified configuration
    /// action to it,  and then appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>
    /// instance.</remarks>
    /// <param name="doubleHtmlElement">The parent HTML element to which the <see cref="Span"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="Span"/> element before it is added as a child.</param>
    /// <returns>The updated <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Span(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Span> action)
    {
        Span tag = new Span();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
