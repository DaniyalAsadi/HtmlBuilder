using System;

namespace HtmlBuilder.Tags.TextContentTag;
/// <summary>
/// Adds an <see cref="H2"/> element as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>  and allows
/// customization of the <see cref="H2"/> element through the provided action.
/// </summary>
/// <remarks>This extension method simplifies the process of adding and configuring an <see cref="H2"/> element 
/// as a child of a <see cref="DoubleHtmlElementWithChildren"/>. The provided <paramref name="action"/>  delegate allows
/// the caller to customize the <see cref="H2"/> element, such as setting attributes or content,  before it is added to
/// the parent.</remarks>
public static class H2Extensions
{
    /// <summary>
    /// Adds an <see cref="H2"/> element as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="H2"/> element through the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="H2"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="H2"/> element before it is added to the parent.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> with the added <see cref="H2"/> child element.</returns>
    public static DoubleHtmlElementWithChildren H2(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<H2> action)
    {
        H2 tag = new H2();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
