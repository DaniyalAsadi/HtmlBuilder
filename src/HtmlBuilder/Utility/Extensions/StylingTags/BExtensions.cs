using System;

namespace HtmlBuilder.Tags.StylingTags;
/// <summary>
/// Adds a new <see cref="B"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/> and allows
/// customization of the <see cref="B"/> element through the provided action.
/// </summary>
public static class BExtensions
{
    /// <summary>
    /// Adds a new <see cref="B"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="B"/> element through the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="B"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="B"/> element before it is added as a child.</param>
    /// <returns>The updated <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren B(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<B> action)
    {
        B tag = new B();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
