namespace HtmlBuilder.Tags.MediaTags;
/// <summary>
/// Provides extension methods for configuring and manipulating <see cref="Iframe"/> elements.
/// </summary>
/// <remarks>This static class contains methods to set common attributes of an <see cref="Iframe"/> element, such
/// as its source URL, dimensions, and frame border. It also includes a method to add an <see cref="Iframe"/> element as
/// a child to a <see cref="DoubleHtmlElementWithChildren"/> instance.</remarks>
public static class IframeExtensions
{
    /// <summary>
    /// Sets the source URL of the iframe element.
    /// </summary>
    /// <param name="tag">The <see cref="Iframe"/> instance to modify.</param>
    /// <param name="src">The URL to set as the source of the iframe. Cannot be null or empty.</param>
    /// <returns>The modified <see cref="Iframe"/> instance.</returns>
    public static Iframe SetSrc(this Iframe tag, string src)
    {
        tag.SetSrc(src);
        return tag;
    }

    /// <summary>
    /// Sets the width of the specified <see cref="Iframe"/> element.
    /// </summary>
    /// <param name="tag">The <see cref="Iframe"/> element to modify.</param>
    /// <param name="width">The width value to set, typically specified as a CSS-compatible string (e.g., "100px", "50%").</param>
    /// <returns>The modified <see cref="Iframe"/> element, allowing for method chaining.</returns>
    public static Iframe SetWidth(this Iframe tag, string width)
    {
        tag.SetWidth(width);
        return tag;
    }

    /// <summary>
    /// Sets the height attribute of the specified <see cref="Iframe"/> tag.
    /// </summary>
    /// <param name="tag">The <see cref="Iframe"/> instance to modify.</param>
    /// <param name="height">The height value to set, typically specified in pixels or as a percentage.</param>
    /// <returns>The modified <see cref="Iframe"/> instance, allowing for method chaining.</returns>
    public static Iframe SetHeight(this Iframe tag, string height)
    {
        tag.SetHeight(height);
        return tag;
    }

    /// <summary>
    /// Sets the value of the "frameborder" attribute for the specified <see cref="Iframe"/> tag.
    /// </summary>
    /// <remarks>This method modifies the "frameborder" attribute of the provided <see cref="Iframe"/> tag and
    /// returns the same tag instance for method chaining.</remarks>
    /// <param name="tag">The <see cref="Iframe"/> tag to which the "frameborder" attribute will be applied.</param>
    /// <param name="frameborder">The value to set for the "frameborder" attribute. Typically, this is "0" or "1" to indicate whether the frame
    /// border should be hidden or visible.</param>
    /// <returns>The updated <see cref="Iframe"/> tag with the specified "frameborder" attribute applied.</returns>
    public static Iframe SetFrameborder(this Iframe tag, string frameborder)
    {
        tag.SetFrameborder(frameborder);
        return tag;
    }

    /// <summary>
    /// Enables the "allowfullscreen" attribute on the specified <see cref="Iframe"/> tag.
    /// </summary>
    /// <param name="tag">The <see cref="Iframe"/> instance to modify.</param>
    /// <returns>The modified <see cref="Iframe"/> instance with the "allowfullscreen" attribute set.</returns>
    public static Iframe SetAllowFullscreen(this Iframe tag)
    {
        tag.SetAllowFullscreen();
        return tag;
    }

    /// <summary>
    /// Adds an <see cref="Iframe"/> element as a child to the current HTML element and allows customization of the <see
    /// cref="Iframe"/> element.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Iframe"/> element, applies the specified configuration
    /// action to it,  and appends it as a child to the specified parent HTML element. The parent element is returned to
    /// allow for method chaining.</remarks>
    /// <param name="doubleHtmlElement">The parent HTML element to which the <see cref="Iframe"/> element will be added.</param>
    /// <param name="action">A delegate that configures the <see cref="Iframe"/> element before it is added to the parent element.</param>
    /// <returns>The parent HTML element with the newly added <see cref="Iframe"/> child element.</returns>
    public static DoubleHtmlElementWithChildren Iframe(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Iframe> action)
    {
        Iframe tag = new Iframe();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
