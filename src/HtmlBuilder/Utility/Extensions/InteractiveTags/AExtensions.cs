using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.InteractiveTags;
/// <summary>
/// Provides extension methods for configuring and manipulating <see cref="A"/> elements.
/// </summary>
/// <remarks>This class includes methods for setting common attributes of <see cref="A"/> elements, such as href,
/// rel, type, and target, as well as a method for adding an <see cref="A"/> element to a <see
/// cref="DoubleHtmlElementWithChildren"/>.</remarks>
public static class AExtensions
{
    /// <summary>
    /// Sets the <c>href</c> attribute of the specified <see cref="A"/> tag to the provided URL.
    /// </summary>
    /// <param name="tag">The <see cref="A"/> tag to modify.</param>
    /// <param name="href">The URL to set as the value of the <c>href</c> attribute. Must be a valid URL.</param>
    /// <returns>The modified <see cref="A"/> tag with the updated <c>href</c> attribute.</returns>
    public static A SetHref(this A tag, string href)
    {
        tag.SetHref(href);
        return tag;
    }

    /// <summary>
    /// Sets the "rel" attribute of the specified tag to the provided value.
    /// </summary>
    /// <param name="tag">The tag to which the "rel" attribute will be applied.</param>
    /// <param name="rel">The value to set for the "rel" attribute. Cannot be null.</param>
    /// <returns>The modified tag with the updated "rel" attribute.</returns>
    public static A SetRel(this A tag, string rel)
    {
        tag.SetRel(rel);
        return tag;
    }

    /// <summary>
    /// Sets the type of the specified tag and returns the updated tag.
    /// </summary>
    /// <param name="tag">The tag to update. Cannot be <see langword="null"/>.</param>
    /// <param name="type">The type to assign to the tag. Cannot be <see langword="null"/> or empty.</param>
    /// <returns>The updated tag with the specified type set.</returns>
    public static A SetType(this A tag, string type)
    {
        tag.SetType(type);
        return tag;
    }

    /// <summary>
    /// Sets the target for the specified <see cref="A"/> instance and returns the updated instance.
    /// </summary>
    /// <param name="tag">The <see cref="A"/> instance to update.</param>
    /// <param name="target">The <see cref="ATarget"/> to set as the target for the <paramref name="tag"/> instance.</param>
    /// <returns>The updated <see cref="A"/> instance with the specified target set.</returns>
    public static A SetTarget(this A tag, ATarget target)
    {
        tag.SetTarget(target);
        return tag;
    }

    /// <summary>
    /// Adds a new <see cref="A"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="A"/> element through the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="A"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{A}"/> delegate that configures the <see cref="A"/> element before it is added as a child.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren A(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<A> action)
    {
        A tag = new A();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
