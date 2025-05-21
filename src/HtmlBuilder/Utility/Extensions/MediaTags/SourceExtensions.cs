using System;

namespace HtmlBuilder.Tags.MediaTags;
/// <summary>
/// Provides extension methods for working with <see cref="Source"/> elements in an HTML-like structure.
/// </summary>
/// <remarks>These extension methods simplify the process of configuring and adding <see cref="Source"/> elements
/// to a parent element, such as a <see cref="DoubleHtmlElementWithChildren"/>. They allow for fluent configuration of
/// attributes and child elements.</remarks>
public static class SourceExtensions
{
    /// <summary>
    /// Sets the <c>src</c> attribute of the specified <see cref="Source"/> tag to the provided value.
    /// </summary>
    /// <param name="tag">The <see cref="Source"/> tag whose <c>src</c> attribute is to be set.</param>
    /// <param name="src">The value to assign to the <c>src</c> attribute. Cannot be null.</param>
    /// <returns>The <see cref="Source"/> tag with the updated <c>src</c> attribute.</returns>
    public static Source SetSrc(this Source tag, string src)
    {
        tag.SetSrc(src);
        return tag;
    }

    /// <summary>
    /// Sets the type of the specified <see cref="Source"/> tag and returns the updated tag.
    /// </summary>
    /// <param name="tag">The <see cref="Source"/> tag to update.</param>
    /// <param name="type">The type to assign to the <see cref="Source"/> tag. Cannot be <see langword="null"/> or empty.</param>
    /// <returns>The updated <see cref="Source"/> tag with the specified type set.</returns>
    public static Source SetType(this Source tag, string type)
    {
        tag.SetType(type);
        return tag;
    }

    /// <summary>
    /// Adds a <see cref="Source"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Source"/> element through the provided action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Source"/> element, applies the specified configuration
    /// action to it,  and appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>.  Use this
    /// method to dynamically construct and configure HTML structures.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Source"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="Source"/> element before it is added as a child.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Source(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Source> action)
    {
        Source tag = new Source();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
