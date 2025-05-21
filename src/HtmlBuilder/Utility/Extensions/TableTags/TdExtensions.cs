using System;

namespace HtmlBuilder.Tags.TableTags;
/// <summary>
/// Provides extension methods for creating and configuring HTML &lt;td&gt; (table data cell) elements.
/// </summary>
public static class TdExtensions
{
    /// <summary>
    /// Sets the <c>colspan</c> attribute for the &lt;td&gt; element, specifying how many columns the cell should span.
    /// </summary>
    /// <param name="tag">The &lt;td&gt; element to configure.</param>
    /// <param name="colspan">The number of columns the cell should span.</param>
    /// <returns>The same &lt;td&gt; element with the <c>colspan</c> attribute set.</returns>
    public static Td SetColspan(this Td tag, int colspan)
    {
        tag.SetColspan(colspan);
        return tag;
    }

    /// <summary>
    /// Sets the <c>rowspan</c> attribute for the &lt;td&gt; element, specifying how many rows the cell should span.
    /// </summary>
    /// <param name="tag">The &lt;td&gt; element to configure.</param>
    /// <param name="rowspan">The number of rows the cell should span.</param>
    /// <returns>The same &lt;td&gt; element with the <c>rowspan</c> attribute set.</returns>
    public static Td SetRowspan(this Td tag, int rowspan)
    {
        tag.SetRowspan(rowspan);
        return tag;
    }

    /// <summary>
    /// Sets the <c>headers</c> attribute for the &lt;td&gt; element, specifying the IDs of the header cells related to this cell.
    /// </summary>
    /// <param name="tag">The &lt;td&gt; element to configure.</param>
    /// <param name="headers">A space-separated list of header cell IDs.</param>
    /// <returns>The same &lt;td&gt; element with the <c>headers</c> attribute set.</returns>
    public static Td SetHeaders(this Td tag, string headers)
    {
        tag.SetHeaders(headers);
        return tag;
    }

    /// <summary>
    /// Adds a &lt;td&gt; element as a child to the current HTML element and allows configuration via the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent element (typically a &lt;tr&gt;) to which the &lt;td&gt; will be added.</param>
    /// <param name="action">A delegate to configure the &lt;td&gt; element (e.g., set attributes or add content).</param>
    /// <returns>The parent element with the configured &lt;td&gt; element added.</returns>
    public static DoubleHtmlElementWithChildren Td(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Td> action)
    {
        Td tag = new Td();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
