using System;

namespace HtmlBuilder.Tags.TextContentTag;
/// <summary>
/// Provides extension methods for working with <see cref="Li"/> elements and  <see
/// cref="DoubleHtmlElementWithChildren"/> objects in an HTML structure.
/// </summary>
/// <remarks>This class includes methods to simplify the creation, configuration, and manipulation of  <see
/// cref="Li"/> elements within a parent <see cref="DoubleHtmlElementWithChildren"/>.  These methods are designed to
/// support fluent API patterns for building HTML structures programmatically.</remarks>
public static class LiExtensions
{
    /// <summary>
    /// Sets the value of the specified <see cref="Li"/> tag and returns the updated tag.
    /// </summary>
    /// <param name="tag">The <see cref="Li"/> tag to update.</param>
    /// <param name="value">The value to set for the <see cref="Li"/> tag.</param>
    /// <returns>The updated <see cref="Li"/> tag with the specified value.</returns>
    public static Li SetValue(this Li tag, string value)
    {
        tag.SetValue(value);
        return tag;
    }

    /// <summary>
    /// Adds a new <see cref="Li"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Li"/> element through the provided action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Li"/> element, applies the specified configuration
    /// action to it,  and appends it to the children of the current <see cref="DoubleHtmlElementWithChildren"/>.  It is
    /// commonly used to build HTML structures programmatically.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Li"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="Li"/> element before it is added as a child.</param>
    /// <returns>The updated <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Li(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Li> action)
    {
        Li tag = new Li();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
