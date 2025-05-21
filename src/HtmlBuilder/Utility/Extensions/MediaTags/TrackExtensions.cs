using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.MediaTags;
/// <summary>
/// Provides extension methods for configuring and adding <see cref="Track"/> elements to an HTML structure.
/// </summary>
/// <remarks>These methods simplify the process of setting attributes on <see cref="Track"/> elements and
/// appending them to parent elements in an HTML document. Each method returns the modified <see cref="Track"/>
/// instance, enabling method chaining.</remarks>
public static class TrackExtensions
{
    /// <summary>
    /// Sets the source URL for the specified <see cref="Track"/> element.
    /// </summary>
    /// <param name="tag">The <see cref="Track"/> element to update.</param>
    /// <param name="src">The source URL to assign to the <see cref="Track"/> element. Cannot be null or empty.</param>
    /// <returns>The updated <see cref="Track"/> element.</returns>
    public static Track SetSrc(this Track tag, string src)
    {
        tag.SetSrc(src);
        return tag;
    }

    /// <summary>
    /// Sets the kind of the specified <see cref="Track"/> and returns the updated instance.
    /// </summary>
    /// <param name="tag">The <see cref="Track"/> instance to update.</param>
    /// <param name="kind">The <see cref="TrackKind"/> value to assign to the <paramref name="tag"/>.</param>
    /// <returns>The updated <see cref="Track"/> instance with the specified kind set.</returns>
    public static Track SetKind(this Track tag, TrackKind kind)
    {
        tag.SetKind(kind);
        return tag;
    }

    /// <summary>
    /// Sets the source language for the track element.
    /// </summary>
    /// <remarks>This method updates the source language of the specified <see cref="Track"/> instance and
    /// returns the same instance for further modifications.</remarks>
    /// <param name="tag">The <see cref="Track"/> instance to modify.</param>
    /// <param name="srclang">The source language code to assign to the track, typically in ISO 639-1 format (e.g., "en" for English).</param>
    /// <returns>The modified <see cref="Track"/> instance, allowing for method chaining.</returns>
    public static Track SetSrclang(this Track tag, string srclang)
    {
        tag.SetSrclang(srclang);
        return tag;
    }

    /// <summary>
    /// Sets the label for the specified <see cref="Track"/> instance and returns the updated instance.
    /// </summary>
    /// <param name="tag">The <see cref="Track"/> instance to update. Cannot be <see langword="null"/>.</param>
    /// <param name="label">The label to assign to the <see cref="Track"/>. Cannot be <see langword="null"/> or empty.</param>
    /// <returns>The updated <see cref="Track"/> instance with the specified label applied.</returns>
    public static Track SetLabel(this Track tag, string label)
    {
        tag.SetLabel(label);
        return tag;
    }

    /// <summary>
    /// Sets the specified <see cref="Track"/> instance to its default state and returns it.
    /// </summary>
    /// <remarks>This method modifies the provided <see cref="Track"/> instance in place by setting it to its
    /// default state. It then returns the same instance for convenience, allowing method chaining or inline
    /// usage.</remarks>
    /// <param name="tag">The <see cref="Track"/> instance to be set to its default state.</param>
    /// <returns>The <see cref="Track"/> instance after being set to its default state.</returns>
    public static Track SetDefault(this Track tag)
    {
        tag.SetDefault();
        return tag;
    }

    /// <summary>
    /// Adds a <see cref="Track"/> element as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Track"/> element through the provided action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Track"/> element, applies the specified configuration
    /// action to it,  and appends it as a child to the provided <see cref="DoubleHtmlElementWithChildren"/>.  Use this
    /// method to dynamically add and configure <see cref="Track"/> elements in an HTML structure.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Track"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="Track"/> element before it is added to the
    /// parent.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Track(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Track> action)
    {
        Track tag = new Track();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
