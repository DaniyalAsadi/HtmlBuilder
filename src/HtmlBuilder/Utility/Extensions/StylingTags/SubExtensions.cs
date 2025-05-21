using System;

namespace HtmlBuilder.Tags.StylingTags;
/// <summary>
/// Adds a <see cref="Sub"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and allows
/// customization of the <see cref="Sub"/> element through the provided action.
/// </summary>
/// <remarks>This method creates a new <see cref="Sub"/> element, applies the specified configuration action to
/// it, and appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>.  Use this method to
/// dynamically construct and configure HTML structures.</remarks>
public static class SubExtensions
{
    /// <summary>
    /// Adds a <see cref="Sub"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Sub"/> element through the provided action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Sub"/> element, applies the specified configuration
    /// action to it,  and appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>.  Use this
    /// method to dynamically construct and configure HTML structures.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Sub"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="Sub"/> element before it is added to the parent.</param>
    /// <returns>The updated <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Sub(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Sub> action)
    {
        Sub tag = new Sub();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
