using System;

namespace HtmlBuilder.Tags.TableTags;
/// <summary>
/// Provides an extension method for creating and configuring an HTML &lt;tfoot&gt; element.
/// </summary>
public static class TfootExtensions
{
    /// <summary>
    /// Adds a &lt;tfoot&gt; element as a child to the current HTML table element and allows configuration via the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent element (typically a &lt;table&gt;) to which the &lt;tfoot&gt; will be added.</param>
    /// <param name="action">A delegate to configure the &lt;tfoot&gt; element (e.g., add &lt;tr&gt; children or set attributes).</param>
    /// <returns>The parent element with the configured &lt;tfoot&gt; element added.</returns>
    public static DoubleHtmlElementWithChildren Tfoot(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Tfoot> action)
    {
        Tfoot tag = new Tfoot();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
