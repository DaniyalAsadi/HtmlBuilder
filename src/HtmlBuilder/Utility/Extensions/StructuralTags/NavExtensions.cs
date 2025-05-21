using System;

namespace HtmlBuilder.Tags.StructuralTags;
/// <summary>
/// Provides extension methods for working with HTML elements, including methods for adding and configuring <see
/// cref="Nav"/> elements.
/// </summary>
/// <remarks>The <see cref="NavExtensions"/> class contains methods that extend the functionality of <see
/// cref="DoubleHtmlElementWithChildren"/> by enabling the addition of <see cref="Nav"/> elements with customizable
/// configurations. These methods support a fluent API style, allowing for method chaining.</remarks>
public static class NavExtensions
{
    /// <summary>
    /// Adds a <see cref="Nav"/> element as a child to the current HTML element and allows customization of the <see
    /// cref="Nav"/> element.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Nav"/> element, applies the specified configuration
    /// action to it,  and appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>
    /// instance.</remarks>
    /// <param name="doubleHtmlElement">The parent HTML element to which the <see cref="Nav"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="Nav"/> element before it is added to the parent.</param>
    /// <returns>The updated <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Nav(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Nav> action)
    {
        Nav tag = new Nav();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
