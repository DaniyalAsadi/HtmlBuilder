using System;

namespace HtmlBuilder.Tags.StructuralTags;
/// <summary>
/// Provides extension methods for working with <see cref="DoubleHtmlElementWithChildren"/> objects, enabling the
/// addition and customization of <see cref="Head"/> elements.
/// </summary>
/// <remarks>The <see cref="HeadExtensions"/> class contains methods that simplify the creation and configuration
/// of <see cref="Head"/> elements within an HTML structure. These methods support a fluent API design, allowing for
/// method chaining and streamlined element manipulation.</remarks>
public static class HeadExtensions
{
    /// <summary>
    /// Adds a <see cref="Head"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Head"/> element through the specified action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Head"/> element, applies the specified action to
    /// configure it,  and then appends it as a child to the provided <see cref="DoubleHtmlElementWithChildren"/>
    /// instance.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Head"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <see cref="Head"/> element.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Head(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Head> action)
    {
        Head tag = new Head();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
