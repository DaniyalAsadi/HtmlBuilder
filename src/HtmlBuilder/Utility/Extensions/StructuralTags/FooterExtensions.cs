using System;

namespace HtmlBuilder.Tags.StructuralTags;
/// <summary>
/// Adds a <see cref="Footer"/> element as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>  and
/// allows customization of the <see cref="Footer"/> element through the provided action.
/// </summary>
/// <remarks>This method creates a new <see cref="Footer"/> element, applies the specified configuration action to
/// it,  and appends it as a child to the provided <see cref="DoubleHtmlElementWithChildren"/>.  Use this method to add
/// and customize a footer section in an HTML structure.</remarks>
public static class FooterExtensions
{
    /// <summary>
    /// Adds a <see cref="Footer"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>
    /// instance and allows customization of the <see cref="Footer"/> element through the specified action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Footer"/> element, applies the provided <paramref
    /// name="action"/> to configure it, and then appends it as a child to the current <see
    /// cref="DoubleHtmlElementWithChildren"/> instance.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Footer"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="Footer"/> element before it is added as a child.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Footer(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Footer> action)
    {
        Footer tag = new Footer();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
