using System;

namespace HtmlBuilder.Tags.TableTags;
/// <summary>
/// Provides an extension method for creating and configuring an HTML &lt;tbody&gt; element.
/// </summary>
public static class TbodyExtensions
{
    /// <summary>
    /// Adds a &lt;tbody&gt; element as a child to the current HTML table element and allows configuration via the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent element (typically a &lt;table&gt;) to which the &lt;tbody&gt; will be added.</param>
    /// <param name="action">A delegate to configure the &lt;tbody&gt; element (e.g., add &lt;tr&gt; children or set attributes).</param>
    /// <returns>The parent element with the configured &lt;tbody&gt; element added.</returns>
    public static DoubleHtmlElementWithChildren Tbody(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Tbody> action)
    {
        Tbody tag = new Tbody();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
