using System;

namespace HtmlBuilder.Tags.StylingTags;
/// <summary>
/// Provides extension methods for working with HTML elements, including methods for adding and configuring <strong>
/// elements.
/// </summary>
/// <remarks>This class contains static methods that extend the functionality of HTML element objects, allowing
/// for the creation and customization of <strong> elements as children of existing HTML elements.</remarks>
public static class StrongExtensions
{
    /// <summary>
    /// Adds a <strong> element as a child to the specified HTML element and allows customization of the <strong>
    /// element.
    /// </summary>
    /// <remarks>This method creates a new <strong> element, applies the specified configuration action to it,
    /// and then appends it as a child to the provided parent HTML element.</remarks>
    /// <param name="doubleHtmlElement">The parent HTML element to which the <strong> element will be added.</param>
    /// <param name="action">An action to configure the <strong> element before it is added to the parent element.</param>
    /// <returns>The parent HTML element with the newly added <strong> element as a child.</returns>
    public static DoubleHtmlElementWithChildren Strong(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Strong> action)
    {
        Strong tag = new Strong();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
