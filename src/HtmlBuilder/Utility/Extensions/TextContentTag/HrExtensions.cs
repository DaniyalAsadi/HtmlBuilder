using System;

namespace HtmlBuilder.Tags.TextContentTag;
/// <summary>
/// Adds an <see cref="Hr"/> element as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>  and allows
/// customization of the <see cref="Hr"/> element through the provided action.
/// </summary>
/// <remarks>This method allows for fluent configuration of an <see cref="Hr"/> element within a parent  <see
/// cref="DoubleHtmlElementWithChildren"/>. The <paramref name="action"/> parameter provides a way  to customize the
/// <see cref="Hr"/> element before it is appended to the parent.</remarks>
public static class HrExtensions
{
    /// <summary>
    /// Adds an <see cref="Hr"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/> instance
    /// and allows customization of the <see cref="Hr"/> element through the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Hr"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="Hr"/> element before it is added to the parent.</param>
    /// <returns>The updated <see cref="DoubleHtmlElementWithChildren"/> instance with the added <see cref="Hr"/> element.</returns>
    public static DoubleHtmlElementWithChildren Hr(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Hr> action)
    {
        Hr tag = new Hr();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
