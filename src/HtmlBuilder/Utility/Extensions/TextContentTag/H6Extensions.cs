using System;

namespace HtmlBuilder.Tags.TextContentTag;
/// <summary>
/// Adds an <see cref="H6"/> element as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>  and allows
/// customization of the <see cref="H6"/> element through the provided action.
/// </summary>
public static class H6Extensions
{
    /// <summary>
    ///     
    /// </summary>
    /// <param name="doubleHtmlElement"></param>
    /// <param name="action"></param>
    /// <returns></returns>
    public static DoubleHtmlElementWithChildren H6(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<H6> action)
    {
        H6 tag = new H6();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
