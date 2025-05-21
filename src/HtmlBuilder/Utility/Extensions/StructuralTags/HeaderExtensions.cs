using System;

namespace HtmlBuilder.Tags.StructuralTags;
/// <summary>
/// Provides extension methods for working with <see cref="DoubleHtmlElementWithChildren"/> objects, enabling fluent
/// construction and customization of HTML elements.
/// </summary>
/// <remarks>The <see cref="HeaderExtensions"/> class contains methods that simplify the process of adding and
/// configuring <see cref="Header"/> elements as children of <see cref="DoubleHtmlElementWithChildren"/> objects. These
/// methods are designed to support fluent API patterns for building HTML structures.</remarks>
public static class HeaderExtensions
{
    /// <summary>
    /// Adds a <see cref="Header"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Header"/> element through the provided action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Header"/> element, applies the specified configuration
    /// action to it,  and then appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>.  Use
    /// this method to fluently build and customize HTML structures.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Header"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="Header"/> element before it is added as a child.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Header(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Header> action)
    {
        Header tag = new Header();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
