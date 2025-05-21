using System;

namespace HtmlBuilder.Tags.TextContentTag;
/// <summary>
/// Provides extension methods for adding &lt;ul&gt; (unordered list) tags to HTML elements.
/// </summary>
public static class UlExtensions
{
    /// <summary>
    /// Adds a &lt;ul&gt; (unordered list) tag as a child to the current HTML element and allows configuration via the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent HTML element to which the &lt;ul&gt; tag will be added.</param>
    /// <param name="action">A configuration action to customize the &lt;ul&gt; tag (e.g., setting attributes or adding children).</param>
    /// <returns>The parent element with the configured &lt;ul&gt; tag added as a child.</returns>
    public static DoubleHtmlElementWithChildren Ul(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Ul> action)
    {
        Ul tag = new Ul();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
