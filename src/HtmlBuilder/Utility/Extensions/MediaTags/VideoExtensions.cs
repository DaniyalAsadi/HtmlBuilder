namespace HtmlBuilder.Tags.MediaTags;
/// <summary>
/// Provides extension methods for configuring and manipulating <see cref="Video"/> elements in an HTML-like structure.
/// </summary>
/// <remarks>This static class contains methods to set various attributes and properties of a <see cref="Video"/>
/// element,  such as its source, controls, autoplay, looping, muted state, width, and height. It also includes a method
/// to add a <see cref="Video"/> element as a child to a <see cref="DoubleHtmlElementWithChildren"/> instance.</remarks>
public static class VideoExtensions
{
    /// <summary>
    /// Sets the source URL for the video element.
    /// </summary>
    /// <param name="tag">The <see cref="Video"/> instance to update.</param>
    /// <param name="src">The source URL to assign to the video element. This value cannot be null or empty.</param>
    /// <returns>The updated <see cref="Video"/> instance, allowing for method chaining.</returns>
    public static Video SetSrc(this Video tag, string src)
    {
        tag.SetSrc(src);
        return tag;
    }

    /// <summary>
    /// Enables the controls for the specified <see cref="Video"/> element.
    /// </summary>
    /// <remarks>This method enables the controls for the <see cref="Video"/> element by invoking its
    /// <c>SetControls</c> method. It returns the modified <see cref="Video"/> element to support fluent API
    /// usage.</remarks>
    /// <param name="tag">The <see cref="Video"/> element to enable controls for.</param>
    /// <returns>The same <see cref="Video"/> element with controls enabled, allowing for method chaining.</returns>
    public static Video SetControls(this Video tag)
    {
        tag.SetControls();
        return tag;
    }

    /// <summary>
    /// Enables autoplay for the specified <see cref="Video"/> tag.
    /// </summary>
    /// <param name="tag">The <see cref="Video"/> tag to enable autoplay for.</param>
    /// <returns>The same <see cref="Video"/> tag instance with autoplay enabled, allowing for method chaining.</returns>
    public static Video SetAutoplay(this Video tag)
    {
        tag.SetAutoplay();
        return tag;
    }

    /// <summary>
    /// Enables looping for the specified <see cref="Video"/> instance.
    /// </summary>
    /// <remarks>This method modifies the provided <see cref="Video"/> instance to enable looping and returns
    /// the same instance for method chaining.</remarks>
    /// <param name="tag">The <see cref="Video"/> instance to enable looping for.</param>
    /// <returns>The same <see cref="Video"/> instance with looping enabled.</returns>
    public static Video SetLoop(this Video tag)
    {
        tag.SetLoop();
        return tag;
    }

    /// <summary>
    /// Sets the video to a muted state and returns the updated video instance.
    /// </summary>
    /// <param name="tag">The <see cref="Video"/> instance to be muted.</param>
    /// <returns>The same <see cref="Video"/> instance with the muted state applied.</returns>
    public static Video SetMuted(this Video tag)
    {
        tag.SetMuted();
        return tag;
    }

    /// <summary>
    /// Sets the width of the video element and returns the updated video instance.
    /// </summary>
    /// <param name="tag">The <see cref="Video"/> instance to update.</param>
    /// <param name="width">The width value to set, typically specified as a CSS-compatible string (e.g., "100px", "50%").</param>
    /// <returns>The updated <see cref="Video"/> instance with the specified width applied.</returns>
    public static Video SetWidth(this Video tag, string width)
    {
        tag.SetWidth(width);
        return tag;
    }

    /// <summary>
    /// Sets the height of the video element and returns the updated video instance.
    /// </summary>
    /// <param name="tag">The <see cref="Video"/> instance to update.</param>
    /// <param name="height">The height value to set, typically specified in pixels or as a CSS-compatible string.</param>
    /// <returns>The updated <see cref="Video"/> instance with the specified height applied.</returns>
    public static Video SetHeight(this Video tag, string height)
    {
        tag.SetHeight(height);
        return tag;
    }

    /// <summary>
    /// Adds a <see cref="Video"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>
    /// instance and allows customization of the <see cref="Video"/> element through the specified action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Video"/> element, applies the specified configuration
    /// action to it, and appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>
    /// instance.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Video"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <see cref="Video"/> element.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Video(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Video> action)
    {
        Video tag = new Video();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
