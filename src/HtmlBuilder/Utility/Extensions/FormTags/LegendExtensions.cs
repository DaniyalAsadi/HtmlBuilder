using System;

namespace HtmlBuilder.Tags.FormTags;
/// <summary>
/// Adds a <see cref="Legend"/> element as a child to the current HTML element and allows customization of the <see
/// cref="Legend"/> element.
/// </summary>
/// <remarks>This method creates a new <see cref="Legend"/> element, applies the specified configuration action to
/// it,  and appends it as a child to the provided <see cref="DoubleHtmlElementWithChildren"/> instance.</remarks>
public static class LegendExtensions
{
    /// <summary>
    /// Adds a <see cref="Legend"/> element as a child to the current HTML element and allows customization of the <see
    /// cref="Legend"/> element.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Legend"/> element, applies the specified configuration
    /// action to it,  and appends it as a child to the provided <see cref="DoubleHtmlElementWithChildren"/>
    /// instance.</remarks>
    /// <param name="doubleHtmlElement">The parent HTML element to which the <see cref="Legend"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="Legend"/> element before it is added to the
    /// parent.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Legend(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Legend> action)
    {
        Legend tag = new Legend();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
