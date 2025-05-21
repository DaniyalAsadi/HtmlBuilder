using System;

namespace HtmlBuilder.Tags.TableTags;
/// <summary>
/// Provides an extension method to create and configure an HTML &lt;tr&gt; (table row) element.
/// </summary>
public static class TrExtensions
{
    /// <summary>
    /// Adds a &lt;tr&gt; element as a child to the current HTML table section or table and allows configuration via the specified action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent HTML element (such as &lt;tbody&gt;, &lt;thead&gt;, or &lt;table&gt;) to which the &lt;tr&gt; element will be added.</param>
    /// <param name="action">A delegate used to configure the &lt;tr&gt; element, such as adding child cells or setting attributes.</param>
    /// <returns>The parent element with the configured &lt;tr&gt; element added as a child.</returns>
    public static DoubleHtmlElementWithChildren Tr(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Tr> action)
    {
        Tr tag = new Tr();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
