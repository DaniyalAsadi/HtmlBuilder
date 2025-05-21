namespace HtmlBuilder.Tags.MediaTags;
/// <summary>
/// Provides extension methods for configuring and manipulating <see cref="Audio"/> elements in a fluent and intuitive
/// manner.
/// </summary>
/// <remarks>This static class contains methods to set common attributes and behaviors for <see cref="Audio"/>
/// elements, such as source, controls, autoplay, looping, and muted state. It also includes a method to add an <see
/// cref="Audio"/> element as a child to a <see cref="DoubleHtmlElementWithChildren"/> instance. These methods are
/// designed to simplify the creation and configuration of audio elements in a fluent API style.</remarks>
public static class AudioExtensions
{
    /// <summary>
    /// Sets the source URL for the audio element.
    /// </summary>
    /// <param name="tag">The <see cref="Audio"/> instance to update.</param>
    /// <param name="src">The URL of the audio source. This must be a valid, non-null string.</param>
    /// <returns>The updated <see cref="Audio"/> instance, allowing for method chaining.</returns>
    public static Audio SetSrc(this Audio tag, string src)
    {
        tag.SetSrc(src);
        return tag;
    }

    /// <summary>
    /// Enables playback controls for the specified <see cref="Audio"/> tag.
    /// </summary>
    /// <param name="tag">The <see cref="Audio"/> tag to enable controls for.</param>
    /// <returns>The same <see cref="Audio"/> instance with playback controls enabled.</returns>
    public static Audio SetControls(this Audio tag)
    {
        tag.SetControls();
        return tag;
    }

    /// <summary>
    /// Enables autoplay for the specified <see cref="Audio"/> tag.
    /// </summary>
    /// <param name="tag">The <see cref="Audio"/> tag to configure for autoplay.</param>
    /// <returns>The same <see cref="Audio"/> tag instance with autoplay enabled.</returns>
    public static Audio SetAutoplay(this Audio tag)
    {
        tag.SetAutoplay();
        return tag;
    }

    /// <summary>
    /// Enables looping for the specified <see cref="Audio"/> instance.
    /// </summary>
    /// <param name="tag">The <see cref="Audio"/> instance to configure for looping.</param>
    /// <returns>The same <see cref="Audio"/> instance with looping enabled, allowing for method chaining.</returns>
    public static Audio SetLoop(this Audio tag)
    {
        tag.SetLoop();
        return tag;
    }

    /// <summary>
    /// Sets the audio tag to a muted state.
    /// </summary>
    /// <param name="tag">The <see cref="Audio"/> instance to be muted.</param>
    /// <returns>The same <see cref="Audio"/> instance with the muted state applied.</returns>
    public static Audio SetMuted(this Audio tag)
    {
        tag.SetMuted();
        return tag;
    }

    /// <summary>
    /// Adds an <see cref="Audio"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>
    /// instance and allows configuration of the <see cref="Audio"/> element through the provided action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Audio"/> element, applies the specified configuration
    /// action to it, and appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>
    /// instance.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Audio"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="Audio"/> element.</param>
    /// <returns>The updated <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Audio(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Audio> action)
    {
        Audio tag = new Audio();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
