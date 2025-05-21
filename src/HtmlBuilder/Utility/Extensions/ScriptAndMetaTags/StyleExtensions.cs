using System;

namespace HtmlBuilder.Tags.ScriptAndMetaTags;
/// <summary>
/// Provides extension methods for working with <see cref="Style"/> elements in the context of HTML generation.
/// </summary>
/// <remarks>These methods allow for convenient configuration and manipulation of <see cref="Style"/> elements,
/// including setting attributes and adding them as children to other HTML elements.</remarks>
public static class StyleExtensions
{
    /// <summary>
    /// Sets the type attribute of the specified <see cref="Style"/> tag and returns the updated tag.
    /// </summary>
    /// <param name="tag">The <see cref="Style"/> tag to update.</param>
    /// <param name="type">The value to set for the type attribute. Cannot be null or empty.</param>
    /// <returns>The updated <see cref="Style"/> tag with the specified type attribute set.</returns>
    public static Style SetType(this Style tag, string type)
    {
        tag.SetType(type);
        return tag;
    }

    /// <summary>
    /// Sets the media attribute for the specified <see cref="Style"/> tag.
    /// </summary>
    /// <param name="tag">The <see cref="Style"/> tag to which the media attribute will be applied.</param>
    /// <param name="media">The media query or media type to associate with the <see cref="Style"/> tag. Cannot be null or empty.</param>
    /// <returns>The updated <see cref="Style"/> tag with the specified media attribute applied.</returns>
    public static Style SetMedia(this Style tag, string media)
    {
        tag.SetMedia(media);
        return tag;
    }

    /// <summary>
    /// Adds a <see cref="Style"/> element as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Style"/> element through the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Style"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <see cref="Style"/> element.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> with the added <see cref="Style"/> element.</returns>
    public static DoubleHtmlElementWithChildren Style(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Style> action)
    {
        Style tag = new Style();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
