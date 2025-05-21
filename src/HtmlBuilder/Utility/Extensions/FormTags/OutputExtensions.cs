using System;

namespace HtmlBuilder.Tags.FormTags;
/// <summary>
/// Provides extension methods for working with <see cref="Output"/> elements in a fluent and customizable manner.
/// </summary>
/// <remarks>These methods allow for configuring and adding <see cref="Output"/> elements to a parent element or
/// modifying their attributes in a concise and readable way.</remarks>
public static class OutputExtensions
{
    /// <summary>
    /// Sets the name of the specified <see cref="Output"/> tag and returns the updated tag.
    /// </summary>
    /// <param name="tag">The <see cref="Output"/> tag to update.</param>
    /// <param name="name">The name to assign to the tag. Cannot be <see langword="null"/> or empty.</param>
    /// <returns>The updated <see cref="Output"/> tag with the specified name.</returns>
    public static Output SetName(this Output tag, string name)
    {
        tag.SetName(name);
        return tag;
    }

    /// <summary>
    /// Sets the form attribute of the specified <see cref="Output"/> tag.
    /// </summary>
    /// <param name="tag">The <see cref="Output"/> tag to modify.</param>
    /// <param name="for">The value to assign to the form attribute. This value specifies the ID of the form element the <see
    /// cref="Output"/> tag is associated with.</param>
    /// <returns>The modified <see cref="Output"/> tag, allowing for method chaining.</returns>
    public static Output SetForm(this Output tag, string @for)
    {
        tag.SetForm(@for);
        return tag;
    }

    /// <summary>
    /// Adds an <see cref="Output"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Output"/> element through the provided action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Output"/> element, applies the specified configuration
    /// action to it,  and appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>.  Use this
    /// method to dynamically construct and configure an <see cref="Output"/> element within a parent HTML
    /// structure.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Output"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <see cref="Output"/> element before it is added as a
    /// child.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Output(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Output> action)
    {
        Output tag = new Output();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
