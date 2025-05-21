using System;

namespace HtmlBuilder.Tags.TextContentTag;
/// <summary>
/// Provides extension methods for adding &lt;p&gt; (paragraph) tags to HTML elements.
/// </summary>
public static class PExtensions
{
    /// <summary>
    /// Adds a &lt;p&gt; (paragraph) tag as a child to the current HTML element and allows configuration via the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent HTML element to which the &lt;p&gt; tag will be added.</param>
    /// <param name="action">A configuration action to customize the &lt;p&gt; tag (e.g., setting attributes or adding children).</param>
    /// <returns>The parent element with the configured &lt;p&gt; tag added as a child.</returns>
    public static DoubleHtmlElementWithChildren P(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<P> action)
    {
        P tag = new P();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
