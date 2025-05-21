using System;

namespace HtmlBuilder.Tags.TextContentTag;
/// <summary>
/// Adds a <see cref="Br"/> element as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>  and allows
/// customization of the <see cref="Br"/> element through the provided action.
/// </summary>
/// <remarks>This method is typically used to add and configure a <see cref="Br"/> element within a fluent API for
/// building HTML structures.</remarks>
public static class BrExtensions
{
    /// <summary>
    /// Adds a <see cref="Br"/> element as a child to the current HTML element and allows customization of the <see
    /// cref="Br"/> element.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent HTML element to which the <see cref="Br"/> element will be added.</param>
    /// <param name="action">An action to configure the <see cref="Br"/> element before it is added to the parent element.</param>
    /// <returns>The parent HTML element with the newly added <see cref="Br"/> element.</returns>
    public static DoubleHtmlElementWithChildren Br(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Br> action)
    {
        Br tag = new Br();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
