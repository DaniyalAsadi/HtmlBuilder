using System;

namespace HtmlBuilder.Tags.TableTags;
public static class ColExtensions
/// <summary>
/// Provides extension methods for working with &lt;col&gt; tags in HTML tables.
/// </summary>
{
    /// <summary>
    /// Sets the <c>span</c> attribute of a &lt;col&gt; tag, indicating how many columns the element should span.
    /// </summary>
    /// <param name="tag">The &lt;col&gt; tag to configure.</param>
    /// <param name="span">The number of columns the &lt;col&gt; tag should span.</param>
    /// <returns>The configured &lt;col&gt; tag.</returns>
    public static Col SetSpan(this Col tag, int span)
    {
        tag.SetSpan(span);
        return tag;
    }

    /// <summary>
    /// Adds a &lt;col&gt; tag as a child to the current HTML table element and allows configuration via the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent HTML element to which the &lt;col&gt; tag will be added.</param>
    /// <param name="action">A configuration action to customize the &lt;col&gt; tag (e.g., setting attributes).</param>
    /// <returns>The parent element with the configured &lt;col&gt; tag added as a child.</returns>
    public static DoubleHtmlElementWithChildren Col(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Col> action)
    {
        Col tag = new Col();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
