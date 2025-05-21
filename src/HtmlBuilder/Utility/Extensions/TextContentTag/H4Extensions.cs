using System;

namespace HtmlBuilder.Tags.TextContentTag;
/// <summary>
/// Provides extension methods for working with <see cref="DoubleHtmlElementWithChildren"/> objects,  enabling the
/// addition and customization of <see cref="H4"/> elements.
/// </summary>
public static class H4Extensions
{
    /// <summary>
    /// Adds an <see cref="H4"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="H4"/> element through the specified action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="H4"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{H4}"/> delegate that configures the <see cref="H4"/> element before it is added as a child.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren H4(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<H4> action)
    {
        H4 tag = new H4();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
