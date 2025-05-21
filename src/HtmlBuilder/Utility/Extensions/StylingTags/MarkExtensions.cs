using System;

namespace HtmlBuilder.Tags.StylingTags;
/// <summary>
/// Adds a <see cref="Mark"/> element as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>  and
/// allows customization of the <see cref="Mark"/> element through the provided action.
/// </summary>
/// <remarks>This extension method simplifies the process of adding and configuring a <see cref="Mark"/> element 
/// as a child of a <see cref="DoubleHtmlElementWithChildren"/>. The provided <paramref name="action"/>  delegate is
/// invoked to configure the <see cref="Mark"/> element before it is added to the parent.</remarks>
public static class MarkExtensions
{
    /// <summary>
    /// Adds a <see cref="Mark"/> element as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Mark"/> element through the provided action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Mark"/> element, applies the specified configuration
    /// action to it,  and then appends it as a child to the provided <see cref="DoubleHtmlElementWithChildren"/>.  Use
    /// this method to dynamically construct and configure HTML elements in a fluent manner.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Mark"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="Mark"/> element before it is added to the
    /// parent.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Mark(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Mark> action)
    {
        Mark tag = new Mark();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
