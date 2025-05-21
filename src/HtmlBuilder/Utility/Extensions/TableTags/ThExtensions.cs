using System;

namespace HtmlBuilder.Tags.TableTags;
/// <summary>
/// Provides extension methods for creating and configuring HTML &lt;th&gt; (table header) elements.
/// </summary>
public static class ThExtensions
{
    /// <summary>
    /// Sets the <c>colspan</c> attribute on the &lt;th&gt; element.
    /// </summary>
    /// <param name="tag">The &lt;th&gt; tag instance to configure.</param>
    /// <param name="colspan">The number of columns the header cell should span.</param>
    /// <returns>The updated &lt;th&gt; tag instance.</returns>
    public static Th SetColspan(this Th tag, int colspan)
    {
        tag.SetColspan(colspan);
        return tag;
    }

    /// <summary>
    /// Sets the <c>rowspan</c> attribute on the &lt;th&gt; element.
    /// </summary>
    /// <param name="tag">The &lt;th&gt; tag instance to configure.</param>
    /// <param name="rowspan">The number of rows the header cell should span.</param>
    /// <returns>The updated &lt;th&gt; tag instance.</returns>
    public static Th SetRowspan(this Th tag, int rowspan)
    {
        tag.SetRowspan(rowspan);
        return tag;
    }

    /// <summary>
    /// Sets the <c>headers</c> attribute on the &lt;th&gt; element.
    /// </summary>
    /// <param name="tag">The &lt;th&gt; tag instance to configure.</param>
    /// <param name="headers">The IDs of header cells this cell is related to, separated by spaces.</param>
    /// <returns>The updated &lt;th&gt; tag instance.</returns>
    public static Th SetHeaders(this Th tag, string headers)
    {
        tag.SetHeaders(headers);
        return tag;
    }

    /// <summary>
    /// Sets the <c>scope</c> attribute on the &lt;th&gt; element.
    /// </summary>
    /// <param name="tag">The &lt;th&gt; tag instance to configure.</param>
    /// <param name="scope">The scope of the header cell (e.g., "col", "row", "colgroup", "rowgroup").</param>
    /// <returns>The updated &lt;th&gt; tag instance.</returns>
    public static Th SetScope(this Th tag, string scope)
    {
        tag.SetScope(scope);
        return tag;
    }

    /// <summary>
    /// Adds a &lt;th&gt; element as a child to the current table row or table section and allows configuration via the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent element to which the &lt;th&gt; element will be added (e.g., &lt;tr&gt;).</param>
    /// <param name="action">A delegate to configure the &lt;th&gt; element.</param>
    /// <returns>The parent element with the configured &lt;th&gt; element added.</returns>
    public static DoubleHtmlElementWithChildren Th(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Th> action)
    {
        Th tag = new Th();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
