using System;

namespace HtmlBuilder.Tags.TableTags;
/// <summary>
/// Provides extension methods for creating and configuring &lt;table&gt; elements in HTML.
/// </summary>
public static class TableExtensions
{
    /// <summary>
    /// Sets the <c>border</c> attribute of the &lt;table&gt; element, defining the width of the border around the table.
    /// </summary>
    /// <param name="tag">The &lt;table&gt; element to configure.</param>
    /// <param name="border">The border width (in pixels) to apply to the table.</param>
    /// <returns>The same &lt;table&gt; element with the <c>border</c> attribute set.</returns>
    public static Table SetBorder(this Table tag, int border)
    {
        tag.SetBorder(border);
        return tag;
    }

    /// <summary>
    /// Sets the <c>summary</c> attribute of the &lt;table&gt; element, which provides a textual description of the table's purpose or structure.
    /// </summary>
    /// <param name="tag">The &lt;table&gt; element to configure.</param>
    /// <param name="summary">A textual summary of the table’s content or purpose.</param>
    /// <returns>The same &lt;table&gt; element with the <c>summary</c> attribute set.</returns>
    public static Table SetSummary(this Table tag, string summary)
    {
        tag.SetSummary(summary);
        return tag;
    }

    /// <summary>
    /// Adds a &lt;table&gt; element as a child to the current HTML element and allows configuration via the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent element to which the &lt;table&gt; will be added.</param>
    /// <param name="action">A delegate to configure the &lt;table&gt; element (e.g., set attributes or add rows).</param>
    /// <returns>The parent element with the configured &lt;table&gt; element added.</returns>
    public static DoubleHtmlElementWithChildren Table(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Table> action)
    {
        Table tag = new Table();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
