using System;

namespace HtmlBuilder.Tags.TextContentTag;
/// <summary>
/// Provides extension methods for adding &lt;pre&gt; (preformatted text) tags to HTML elements.
/// </summary>
public static class PreExtensions
{
    /// <summary>
    /// Adds a &lt;pre&gt; (preformatted text) tag as a child to the current HTML element and allows configuration via the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent HTML element to which the &lt;pre&gt; tag will be added.</param>
    /// <param name="action">A configuration action to customize the &lt;pre&gt; tag (e.g., setting attributes or adding children).</param>
    /// <returns>The parent element with the configured &lt;pre&gt; tag added as a child.</returns>
    public static DoubleHtmlElementWithChildren Pre(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Pre> action)
    {
        Pre tag = new Pre();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
