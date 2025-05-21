using System;

namespace HtmlBuilder.Tags.StylingTags;
/// <summary>
/// Adds a new <see cref="S"/> element as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>  and
/// allows configuration of the <see cref="S"/> element through the provided action.
/// </summary>
/// <remarks>This method simplifies the process of adding and configuring <see cref="S"/> elements  to a <see
/// cref="DoubleHtmlElementWithChildren"/>. The <paramref name="action"/> parameter  allows the caller to specify custom
/// configuration logic for the <see cref="S"/> element.</remarks>
public static class SExtensions
{
    /// <summary>
    /// Adds a new <see cref="S"/> element as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows configuration of the <see cref="S"/> element through the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="S"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="S"/> element before it is added as a child.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> with the new <see cref="S"/> element added as a child.</returns>
    public static DoubleHtmlElementWithChildren S(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<S> action)
    {
        S tag = new S();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
