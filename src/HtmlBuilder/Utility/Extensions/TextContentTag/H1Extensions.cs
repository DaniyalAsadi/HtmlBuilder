using System;

namespace HtmlBuilder.Tags.TextContentTag;
/// <summary>
/// Provides extension methods for working with <see cref="DoubleHtmlElementWithChildren"/> objects, enabling the
/// addition and customization of <see cref="H1"/> elements.
/// </summary>
/// <remarks>This class contains methods that simplify the creation and configuration of <see cref="H1"/> elements
/// as children of <see cref="DoubleHtmlElementWithChildren"/> instances. These methods support a fluent API design,
/// allowing for method chaining.</remarks>
public static class H1Extensions
{
    /// <summary>
    /// Adds an <see cref="H1"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="H1"/> element through the specified action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="H1"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{H1}"/> delegate that configures the <see cref="H1"/> element before it is added to the
    /// parent.</param>
    /// <returns>The updated <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren H1(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<H1> action)
    {
        H1 tag = new H1();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
