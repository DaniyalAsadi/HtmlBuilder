using System;

namespace HtmlBuilder.Tags.TextContentTag;
/// <summary>
/// Adds an <see cref="H5"/> element as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>  and allows
/// customization of the <see cref="H5"/> element through the provided action.
/// </summary>
/// <remarks>This method simplifies the creation and addition of an <see cref="H5"/> element to a parent HTML
/// element,  allowing the caller to configure the <see cref="H5"/> element using the provided action.</remarks>
public static class H5Extensions
{
    /// <summary>
    /// Adds an <c>&lt;h5&gt;</c> element as a child to the current HTML element and allows customization of the
    /// <c>&lt;h5&gt;</c> element.
    /// </summary>
    /// <remarks>This method creates a new <c>&lt;h5&gt;</c> element, applies the specified configuration
    /// action to it,  and appends it as a child to the specified parent element. Use this method to dynamically
    /// construct  and customize <c>&lt;h5&gt;</c> elements within an HTML structure.</remarks>
    /// <param name="doubleHtmlElement">The parent HTML element to which the <c>&lt;h5&gt;</c> element will be added.</param>
    /// <param name="action">A delegate that configures the <c>&lt;h5&gt;</c> element before it is added to the parent element.</param>
    /// <returns>The parent HTML element with the newly added <c>&lt;h5&gt;</c> child element.</returns>
    public static DoubleHtmlElementWithChildren H5(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<H5> action)
    {
        H5 tag = new H5();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
