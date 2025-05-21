using System;

namespace HtmlBuilder.Tags.StylingTags;
/// <summary>
/// Adds an <see cref="I"/> element as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>  and allows
/// customization of the <see cref="I"/> element through the provided action.
/// </summary>
/// <remarks>This method creates a new <see cref="I"/> element, applies the specified configuration action to it, 
/// and then appends it as a child to the provided <see cref="DoubleHtmlElementWithChildren"/>.  Use this method to add
/// and customize <i>italic</i> elements in an HTML-like structure.</remarks>
public static class IExtensions
{
    /// <summary>
    /// Adds an <i> (italic) HTML element as a child to the specified parent element and allows customization of the <i>
    /// element.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent HTML element to which the <i> element will be added.</param>
    /// <param name="action">A delegate to configure the <i> element before it is added to the parent element.</param>
    /// <returns>The parent HTML element with the newly added <i> element as a child.</returns>
    public static DoubleHtmlElementWithChildren I(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<I> action)
    {
        I tag = new I();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
