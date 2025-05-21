using System;

namespace HtmlBuilder.Tags.StructuralTags;
/// <summary>
/// Adds a <see cref="Main"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/> and allows
/// customization of the <see cref="Main"/> element through the provided action.
/// </summary>
/// <remarks>This method creates a new <see cref="Main"/> element, applies the specified configuration action to
/// it, and then appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>.  Use this method to
/// dynamically construct and configure a <see cref="Main"/> element within an HTML structure. This method supports
/// method chaining by returning the modified <see cref="DoubleHtmlElementWithChildren"/> instance.</remarks>
public static class MainExtensions
{
    /// <summary>
    /// Adds a <see cref="Main"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/> and
    /// allows customization of the <see cref="Main"/> element through the provided action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Main"/> element, applies the specified configuration
    /// action to it, and then appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>. Use
    /// this method to dynamically construct and configure a <see cref="Main"/> element within an HTML
    /// structure.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Main"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <see cref="Main"/> element before it is added as a
    /// child.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Main(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Main> action)
    {
        Main tag = new Main();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
