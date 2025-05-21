using System;

namespace HtmlBuilder.Tags.FormTags;
/// <summary>
/// Provides extension methods for working with <see cref="Label"/> elements, enabling fluent API patterns for setting
/// attributes and adding child elements.
/// </summary>
/// <remarks>This static class includes methods to simplify the manipulation of <see cref="Label"/> elements, such
/// as setting the <c>for</c> attribute and appending <see cref="Label"/> elements to <see
/// cref="DoubleHtmlElementWithChildren"/> instances. These methods are designed to enhance readability and streamline
/// the creation of HTML structures in a programmatic context.</remarks>
public static class LabelExtensions
{
    /// <summary>
    /// Sets the <c>for</c> attribute of the specified <see cref="Label"/> element to the provided value.
    /// </summary>
    /// <remarks>This method is an extension method for the <see cref="Label"/> class, enabling a fluent API
    /// style for setting the <c>for</c> attribute.</remarks>
    /// <param name="tag">The <see cref="Label"/> element to modify.</param>
    /// <param name="for">The value to assign to the <c>for</c> attribute. Typically, this corresponds to the ID of the associated form
    /// element.</param>
    /// <returns>The modified <see cref="Label"/> element, allowing for method chaining.</returns>
    public static Label SetFor(this Label tag, string @for)
    {
        tag.SetFor(@for);
        return tag;
    }

    /// <summary>
    /// Adds a <see cref="Label"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Label"/> element through the specified action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Label"/> element, applies the specified configuration
    /// action to it,  and then appends it as a child to the provided <see cref="DoubleHtmlElementWithChildren"/>
    /// instance.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Label"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <see cref="Label"/> element before it is added to the
    /// parent.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Label(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Label> action)
    {
        Label tag = new Label();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
