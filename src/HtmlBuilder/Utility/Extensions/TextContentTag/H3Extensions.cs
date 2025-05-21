using System;

namespace HtmlBuilder.Tags.TextContentTag;
/// <summary>
/// Adds an <see cref="H3"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and allows
/// customization of the <see cref="H3"/> element through the provided action.
/// </summary>
/// <remarks>This method simplifies the process of adding and configuring an <see cref="H3"/> element as a child 
/// of a <see cref="DoubleHtmlElementWithChildren"/>. The provided <paramref name="action"/> delegate  can be used to
/// set attributes or add content to the <see cref="H3"/> element before it is appended  to the parent
/// element.</remarks>
public static class H3Extensions
{
    /// <summary>
    /// Adds an <see cref="H3"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="H3"/> element through the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="H3"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="H3"/> element before it is added as a child.</param>
    /// <returns>The updated <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren H3(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<H3> action)
    {
        H3 tag = new H3();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
