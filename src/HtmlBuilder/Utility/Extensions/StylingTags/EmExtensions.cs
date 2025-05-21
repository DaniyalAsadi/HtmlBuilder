using System;

namespace HtmlBuilder.Tags.StylingTags;
/// <summary>
/// Provides extension methods for working with <see cref="DoubleHtmlElementWithChildren"/> elements,  enabling the
/// addition and customization of <see cref="Em"/> child elements.
/// </summary>
public static class EmExtensions
{
    /// <summary>
    /// Adds an <see cref="Em"/> element as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Em"/> element through the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Em"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="Em"/> element before it is added to the parent.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> with the added <see cref="Em"/> child element.</returns>
    public static DoubleHtmlElementWithChildren Em(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Em> action)
    {
        Em tag = new Em();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
