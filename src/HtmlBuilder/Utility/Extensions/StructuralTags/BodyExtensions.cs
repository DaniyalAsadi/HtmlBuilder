using System;

namespace HtmlBuilder.Tags.StructuralTags;
/// <summary>
/// Provides extension methods for working with HTML elements, specifically for adding and configuring <see
/// cref="Body"/> elements.
/// </summary>
/// <remarks>This class contains methods that extend the functionality of <see
/// cref="DoubleHtmlElementWithChildren"/> to simplify the creation and configuration of <see cref="Body"/> elements
/// within an HTML structure. These methods support fluent method chaining for building complex HTML
/// hierarchies.</remarks>
public static class BodyExtensions
{
    /// <summary>
    /// Adds a <see cref="Body"/> element as a child to the current HTML element and allows configuration of the <see
    /// cref="Body"/> element.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Body"/> element, applies the specified configuration
    /// action to it,  and then adds it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>
    /// instance.</remarks>
    /// <param name="doubleHtmlElement">The parent HTML element to which the <see cref="Body"/> element will be added.</param>
    /// <param name="action">An action to configure the <see cref="Body"/> element before it is added as a child.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Body(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Body> action)
    {
        Body tag = new Body();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
