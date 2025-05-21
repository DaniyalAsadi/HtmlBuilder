using System;

namespace HtmlBuilder.Tags.TextContentTag;
/// <summary>
/// Provides extension methods for working with <see cref="DoubleHtmlElementWithChildren"/> objects, enabling the
/// addition and customization of <see cref="Dd"/> elements.
/// </summary>
/// <remarks>The <see cref="DdExtensions"/> class contains methods that simplify the creation and configuration of
/// <see cref="Dd"/> elements as children of <see cref="DoubleHtmlElementWithChildren"/> objects. These methods are
/// designed to facilitate the programmatic construction of HTML-like structures.</remarks>
public static class DdExtensions
{
    /// <summary>
    /// Adds a <see cref="Dd"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Dd"/> element through the provided action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Dd"/> element, applies the specified configuration
    /// action to it,  and then appends it as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>.  It
    /// is commonly used to build HTML structures programmatically.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Dd"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="Dd"/> element before it is added to the parent.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Dd(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Dd> action)
    {
        Dd tag = new Dd();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
