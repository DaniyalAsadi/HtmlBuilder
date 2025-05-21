using System;

namespace HtmlBuilder.Tags.TextContentTag;
/// <summary>
/// Provides extension methods for working with <see cref="DoubleHtmlElementWithChildren"/> objects, enabling the
/// creation and customization of <see cref="Dl"/> elements within the element hierarchy.
/// </summary>
/// <remarks>The <see cref="DlExtensions"/> class contains methods that simplify the process of adding <see
/// cref="Dl"/> elements to a <see cref="DoubleHtmlElementWithChildren"/> instance. These methods allow for fluent
/// configuration and chaining, making it easier to construct and manage HTML-like element trees
/// programmatically.</remarks>
public static class DlExtensions
{
    /// <summary>
    /// Adds a <see cref="Dl"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Dl"/> element through the provided action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Dl"/> element, applies the specified configuration
    /// action to it,  and then appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>.  Use
    /// this method to construct and customize a <see cref="Dl"/> element within the parent element's
    /// hierarchy.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Dl"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="Dl"/> element before it is added as a child.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Dl(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Dl> action)
    {
        Dl tag = new Dl();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
