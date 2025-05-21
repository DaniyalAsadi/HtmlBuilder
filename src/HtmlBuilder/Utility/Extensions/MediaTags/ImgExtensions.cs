using System;

namespace HtmlBuilder.Tags.MediaTags;
/// <summary>
/// Provides extension methods for configuring and adding <see cref="Img"/> elements to an HTML structure.
/// </summary>
/// <remarks>This static class contains methods to set attributes such as "src", "alt", "width", and "height" on
/// <see cref="Img"/> elements, as well as a method to add an <see cref="Img"/> element to a parent <see
/// cref="DoubleHtmlElementWithChildren"/>. These methods are designed to simplify the creation and configuration of
/// <see cref="Img"/> elements in a fluent API style.</remarks>
public static class ImgExtensions
{
    /// <summary>
    /// Sets the source URL of the <see cref="Img"/> tag and returns the updated tag.
    /// </summary>
    /// <param name="tag">The <see cref="Img"/> tag to update.</param>
    /// <param name="src">The source URL to set for the <see cref="Img"/> tag. Cannot be null or empty.</param>
    /// <returns>The updated <see cref="Img"/> tag with the specified source URL.</returns>
    public static Img SetSrc(this Img tag, string src)
    {
        tag.SetSrc(src);
        return tag;
    }

    /// <summary>
    /// Sets the "alt" attribute of the specified <see cref="Img"/> tag to the provided value.
    /// </summary>
    /// <param name="tag">The <see cref="Img"/> tag to modify.</param>
    /// <param name="alt">The value to set for the "alt" attribute. This should describe the image for accessibility purposes.</param>
    /// <returns>The modified <see cref="Img"/> tag, allowing for method chaining.</returns>
    public static Img SetAlt(this Img tag, string alt)
    {
        tag.SetAlt(alt);
        return tag;
    }

    /// <summary>
    /// Sets the width of the specified <see cref="Img"/> tag and returns the updated tag.
    /// </summary>
    /// <param name="tag">The <see cref="Img"/> tag to update.</param>
    /// <param name="width">The width value to set. This can be any valid CSS width value, such as "100px" or "50%".</param>
    /// <returns>The updated <see cref="Img"/> tag with the specified width applied.</returns>
    public static Img SetWidth(this Img tag, string width)
    {
        tag.SetWidth(width);
        return tag;
    }

    /// <summary>
    /// Sets the height attribute of the specified <see cref="Img"/> tag and returns the updated tag.
    /// </summary>
    /// <param name="tag">The <see cref="Img"/> tag to update.</param>
    /// <param name="height">The height value to set. This can be any valid CSS height value, such as "100px" or "50%".</param>
    /// <returns>The updated <see cref="Img"/> tag with the specified height applied.</returns>
    public static Img SetHeight(this Img tag, string height)
    {
        tag.SetHeight(height);
        return tag;
    }

    /// <summary>
    /// Adds an <see cref="Img"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Img"/> element through the specified action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Img"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <see cref="Img"/> element.</param>
    /// <returns>The updated <see cref="DoubleHtmlElementWithChildren"/> with the added <see cref="Img"/> element.</returns>
    public static DoubleHtmlElementWithChildren Img(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Img> action)
    {
        Img tag = new Img();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
