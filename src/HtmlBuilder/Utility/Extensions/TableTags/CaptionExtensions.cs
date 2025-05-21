using System;

namespace HtmlBuilder.Tags.TableTags;
/// <summary>
/// Provides extension methods for adding &lt;caption&gt; tags to HTML table elements.
/// </summary> 
public static class CaptionExtensions
{
    /// <summary>
    /// Adds a &lt;caption&gt; tag to the current HTML table element and allows configuration via the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent HTML table element to which the &lt;caption&gt; tag will be added.</param>
    /// <param name="action">A configuration action to customize the &lt;caption&gt; tag (e.g., setting attributes or adding children).</param>
    /// <returns>The parent element with the configured &lt;caption&gt; tag added as a child.</returns>
    public static DoubleHtmlElementWithChildren Caption(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Caption> action)
    {
        Caption tag = new Caption();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
