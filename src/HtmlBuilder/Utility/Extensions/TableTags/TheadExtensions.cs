using System;

namespace HtmlBuilder.Tags.TableTags;
/// <summary>
/// Provides an extension method for creating and configuring an HTML &lt;thead&gt; element.
/// </summary>
public static class TheadExtensions
{
    /// <summary>
    /// Adds a &lt;thead&gt; element as a child to the current HTML table element and allows configuration via the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent element (typically a &lt;table&gt;) to which the &lt;thead&gt; will be added.</param>
    /// <param name="action">A delegate to configure the &lt;thead&gt; element (e.g., add &lt;tr&gt; children or set attributes).</param>
    /// <returns>The parent element with the configured &lt;thead&gt; element added.</returns>
    public static DoubleHtmlElementWithChildren Thead(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Thead> action)
    {
        Thead tag = new Thead();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
