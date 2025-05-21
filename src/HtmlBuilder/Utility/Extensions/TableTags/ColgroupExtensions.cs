using System;

namespace HtmlBuilder.Tags.TableTags;
/// <summary>
/// Provides extension methods for creating and configuring &lt;colgroup&gt; elements in HTML tables.
/// </summary>
public static class ColgroupExtensions
{
    /// <summary>
    /// Sets the <c>span</c> attribute of the &lt;colgroup&gt; element, specifying how many columns the group should span.
    /// </summary>
    /// <param name="tag">The &lt;colgroup&gt; element to configure.</param>
    /// <param name="span">The number of columns this &lt;colgroup&gt; should span.</param>
    /// <returns>The same &lt;colgroup&gt; element with the <c>span</c> attribute set.</returns>
    public static Colgroup SetSpan(this Colgroup tag, int span)
    {
        tag.SetSpan(span);
        return tag;
    }

    /// <summary>
    /// Adds a &lt;colgroup&gt; element as a child to the current HTML table element and allows configuration via the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent element (typically a &lt;table&gt;) to which the &lt;colgroup&gt; will be added.</param>
    /// <param name="action">A delegate to configure the &lt;colgroup&gt; element (e.g., set attributes or add &lt;col&gt; children).</param>
    /// <returns>The parent element with the configured &lt;colgroup&gt; element added.</returns>
    public static DoubleHtmlElementWithChildren Colgroup(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Colgroup> action)
    {
        Colgroup tag = new Colgroup();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
