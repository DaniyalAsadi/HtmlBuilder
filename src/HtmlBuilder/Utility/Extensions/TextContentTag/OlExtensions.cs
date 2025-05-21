namespace HtmlBuilder.Tags.TextContentTag;
/// <summary>
/// Provides extension methods for working with <see cref="Ol"/> elements in an HTML-like structure.
/// </summary>
/// <remarks>This class includes methods to configure and manipulate <see cref="Ol"/> elements, such as setting
/// their type,  start value, or reversed state, as well as adding them as children to a <see
/// cref="DoubleHtmlElementWithChildren"/>.</remarks>
public static class OlExtensions
{
    /// <summary>
    /// Sets the type attribute of the specified <see cref="Ol"/> tag.
    /// </summary>
    /// <param name="tag">The <see cref="Ol"/> tag to modify.</param>
    /// <param name="type">The value to set for the type attribute. This value determines the style of the list.</param>
    /// <returns>The modified <see cref="Ol"/> tag with the updated type attribute.</returns>
    public static Ol SetType(this Ol tag, string type)
    {
        tag.SetType(type);
        return tag;
    }

    /// <summary>
    /// Sets the starting value for the ordered list and returns the updated list.
    /// </summary>
    /// <param name="tag">The <see cref="Ol"/> instance to update.</param>
    /// <param name="start">The starting value for the ordered list. Must be a non-negative integer.</param>
    /// <returns>The updated <see cref="Ol"/> instance with the specified starting value.</returns>
    public static Ol SetStart(this Ol tag, int start)
    {
        tag.SetStart(start);
        return tag;
    }

    /// <summary>
    /// Sets the "reversed" attribute on the specified <see cref="Ol"/> tag and returns the updated tag.
    /// </summary>
    /// <param name="tag">The <see cref="Ol"/> tag to modify. Cannot be <see langword="null"/>.</param>
    /// <returns>The modified <see cref="Ol"/> tag with the "reversed" attribute set.</returns>
    public static Ol SetReversed(this Ol tag)
    {
        tag.SetReversed();
        return tag;
    }

    /// <summary>
    /// Adds an &lt;ol&gt; (ordered list) tag as a child to the current HTML element and allows configuration via the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent HTML element to which the &lt;ol&gt; tag will be added.</param>
    /// <param name="action">A configuration action to customize the &lt;ol&gt; tag (e.g., setting attributes or adding children).</param>
    /// <returns>The parent element with the configured &lt;ol&gt; tag added as a child.</returns>
    public static DoubleHtmlElementWithChildren Ol(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Ol> action)
    {
        Ol tag = new Ol();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
