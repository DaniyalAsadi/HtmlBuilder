using System;

namespace HtmlBuilder.Tags.TextContentTag;
/// <summary>
/// Provides extension methods for working with <see cref="Figcaption"/> elements in HTML structures.
/// </summary>
/// <remarks>This class contains methods that simplify the creation and customization of <see cref="Figcaption"/>
/// elements within a fluent API for building HTML structures. These methods allow developers to add and configure <see
/// cref="Figcaption"/> elements as children of existing HTML elements.</remarks>
public static class FigcaptionExtensions
{
    /// <summary>
    /// Adds a <see cref="Figcaption"/> element as a child to the current HTML element and allows customization of the
    /// <see cref="Figcaption"/> element.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Figcaption"/> element, applies the specified
    /// configuration action to it,  and appends it as a child to the provided parent element. This enables fluent API
    /// usage for building HTML structures.</remarks>
    /// <param name="doubleHtmlElement">The parent HTML element to which the <see cref="Figcaption"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <see cref="Figcaption"/> element.</param>
    /// <returns>The modified parent HTML element, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Figcaption(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Figcaption> action)
    {
        Figcaption tag = new Figcaption();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
