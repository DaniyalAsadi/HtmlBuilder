using System;

namespace HtmlBuilder.Tags.StylingTags;
/// <summary>
/// Provides extension methods for working with <see cref="DoubleHtmlElementWithChildren"/> elements, enabling the
/// addition and customization of <see cref="Sup"/> elements.
/// </summary>
/// <remarks>The <see cref="SupExtensions"/> class contains methods that simplify the creation and configuration
/// of <see cref="Sup"/> elements, which represent superscript elements in HTML. These methods allow developers to
/// fluently build and modify HTML structures by appending <see cref="Sup"/> elements to parent elements.</remarks>
public static class SupExtensions
{
    /// <summary>
    /// Adds a <see cref="Sup"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Sup"/> element through the provided action.
    /// </summary>
    /// <remarks>The <see cref="Sup"/> element represents a superscript element in HTML. This method enables
    /// the caller to  define and configure the <see cref="Sup"/> element's attributes and content before appending it
    /// to the parent element.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Sup"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="Sup"/> element before it is added to the parent.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Sup(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Sup> action)
    {
        Sup tag = new Sup();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
