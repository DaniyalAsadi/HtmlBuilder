using System;

namespace HtmlBuilder.Tags.StructuralTags;
/// <summary>
/// Adds an <see cref="Aside"/> element as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>  and
/// allows customization of the <see cref="Aside"/> element through the provided action.
/// </summary>
/// <remarks>This method creates a new <see cref="Aside"/> element, applies the specified configuration action to
/// it,  and then appends it as a child to the provided <see cref="DoubleHtmlElementWithChildren"/>.  Use this method to
/// dynamically construct and configure an <see cref="Aside"/> element within an HTML structure.</remarks>
public static class AsideExtensions
{
    /// <summary>
    /// Adds an <see cref="Aside"/> element as a child to the current HTML element and allows customization of the <see
    /// cref="Aside"/> element.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Aside"/> element, applies the specified <paramref
    /// name="action"/> to configure it,  and then adds it as a child to the specified <paramref
    /// name="doubleHtmlElement"/>.  Use this method to structure HTML content programmatically.</remarks>
    /// <param name="doubleHtmlElement">The parent HTML element to which the <see cref="Aside"/> element will be added.</param>
    /// <param name="action">An action to configure the <see cref="Aside"/> element before it is added as a child.</param>
    /// <returns>The updated <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Aside(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Aside> action)
    {
        Aside tag = new Aside();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
