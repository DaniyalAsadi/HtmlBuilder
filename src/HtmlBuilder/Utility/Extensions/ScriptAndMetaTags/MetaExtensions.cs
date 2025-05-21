using System;

namespace HtmlBuilder.Tags.ScriptAndMetaTags;
/// <summary>
/// Provides extension methods for configuring and adding <see cref="Meta"/> elements to an HTML structure.
/// </summary>
/// <remarks>This class includes methods for setting common attributes of <see cref="Meta"/> elements, such as
/// "name", "content", "http-equiv", and "charset". It also provides a method for adding a <see cref="Meta"/> element to
/// a parent <see cref="DoubleHtmlElementWithChildren"/>.</remarks>
public static class MetaExtensions
{
    /// <summary>
    /// Sets the name of the specified <see cref="Meta"/> tag and returns the updated tag.
    /// </summary>
    /// <param name="tag">The <see cref="Meta"/> instance to update. Cannot be <see langword="null"/>.</param>
    /// <param name="name">The name to assign to the <see cref="Meta"/> tag. Cannot be <see langword="null"/> or empty.</param>
    /// <returns>The updated <see cref="Meta"/> instance with the specified name.</returns>
    public static Meta SetName(this Meta tag, string name)
    {
        tag.SetName(name);
        return tag;
    }

    /// <summary>
    /// Sets the content of the specified <see cref="Meta"/> tag and returns the updated tag.
    /// </summary>
    /// <param name="tag">The <see cref="Meta"/> tag to update. Cannot be <see langword="null"/>.</param>
    /// <param name="content">The content to set for the <see cref="Meta"/> tag. Can be an empty string but cannot be <see langword="null"/>.</param>
    /// <returns>The updated <see cref="Meta"/> tag with the specified content set.</returns>
    public static Meta SetContent(this Meta tag, string content)
    {
        tag.SetContent(content);
        return tag;
    }
    
    /// <summary>
    /// Sets the HTTP-equivalent header name for the <see cref="Meta"/> tag.
    /// </summary>
    /// <param name="tag">The <see cref="Meta"/> tag to modify. Cannot be <c>null</c>.</param>
    /// <param name="httpEquiv">The HTTP-equivalent header name to set. Cannot be <c>null</c> or empty.</param>
    /// <returns>The modified <see cref="Meta"/> tag, allowing for method chaining.</returns>
    public static Meta SetHttpEquiv(this Meta tag, string httpEquiv)
    {
        tag.SetHttpEquiv(httpEquiv);
        return tag;
    }

    /// <summary>
    /// Sets the character set for the specified <see cref="Meta"/> tag.
    /// </summary>
    /// <param name="tag">The <see cref="Meta"/> tag to update.</param>
    /// <param name="charset">The character set to assign to the <see cref="Meta"/> tag. Cannot be <see langword="null"/> or empty.</param>
    /// <returns>The updated <see cref="Meta"/> tag with the specified character set applied.</returns>
    public static Meta SetCharset(this Meta tag, string charset)
    {
        tag.SetCharset(charset);
        return tag;
    }

    /// <summary>
    /// Adds a <see cref="Meta"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows configuration of the <see cref="Meta"/> element through the specified action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Meta"/> element, applies the specified configuration
    /// action to it,  and then adds it as a child to the provided <see cref="DoubleHtmlElementWithChildren"/>.  Use
    /// this method to dynamically construct and configure meta elements within an HTML structure.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Meta"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate used to configure the <see cref="Meta"/> element before it is added as a
    /// child.</param>
    /// <returns>The updated <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Meta(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Meta> action)
    {
        Meta tag = new Meta();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
