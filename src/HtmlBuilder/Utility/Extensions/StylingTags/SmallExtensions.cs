using System;

namespace HtmlBuilder.Tags.StylingTags;
/// <summary>
/// Provides extension methods for working with <see cref="DoubleHtmlElementWithChildren"/> objects, enabling the
/// addition and customization of <see cref="Small"/> elements.
/// </summary>
/// <remarks>The <see cref="SmallExtensions"/> class contains methods that simplify the process of adding <see
/// cref="Small"/> elements to a <see cref="DoubleHtmlElementWithChildren"/> instance. These methods support fluent
/// syntax, allowing for streamlined and readable code when building HTML structures.</remarks>
public static class SmallExtensions
{
    /// <summary>
    /// Adds a <see cref="Small"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Small"/> element through the provided action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Small"/> element, applies the specified configuration
    /// action to it,  and appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>.  Use this
    /// method to add and customize a <see cref="Small"/> element in a fluent manner.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Small"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="Small"/> element before it is added as a child.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Small(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Small> action)
    {
        Small tag = new Small();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
