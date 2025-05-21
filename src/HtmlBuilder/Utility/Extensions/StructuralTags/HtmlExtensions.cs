using System;

namespace HtmlBuilder.Tags.StructuralTags;
/// <summary>
/// Provides extension methods for working with HTML elements in a fluent and customizable manner.
/// </summary>
/// <remarks>This class includes methods for setting attributes on HTML elements and for creating nested HTML
/// structures. The methods are designed to be used with a fluent API style, enabling concise and readable code for
/// building HTML elements.</remarks>
public static class HtmlExtensions
{
    /// <summary>
    /// Sets the language attribute of the specified HTML tag.
    /// </summary>
    /// <param name="tag">The HTML tag to which the language attribute will be applied.</param>
    /// <param name="lang">The language code to set, such as "en" for English or "fr" for French. Cannot be null or empty.</param>
    /// <returns>The modified <see cref="Html"/> tag with the updated language attribute.</returns>
    public static Html SetLang(this Html tag, string lang)
    {
        tag.SetLang(lang);
        return tag;
    }

    /// <summary>
    /// Sets the manifest URL for the specified HTML tag.
    /// </summary>
    /// <param name="tag">The <see cref="Html"/> instance to which the manifest URL will be applied.</param>
    /// <param name="manifestUrl">The URL of the manifest to associate with the HTML tag. Cannot be null or empty.</param>
    /// <returns>The updated <see cref="Html"/> instance with the manifest URL set.</returns>
    public static Html SetManifest(this Html tag, string manifestUrl)
    {
        tag.SetManifest(manifestUrl);
        return tag;
    }

    /// <summary>
    /// Adds an <see cref="Html"/> element as a child to the current element and allows configuration of the <see
    /// cref="Html"/> element.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Html"/> element, applies the specified configuration
    /// action to it,  and then adds it as a child to the current element. Use this method to dynamically construct and
    /// configure  an <see cref="Html"/> element within the context of a parent element.</remarks>
    /// <param name="doubleHtmlElement">The parent element to which the <see cref="Html"/> element will be added.</param>
    /// <param name="action">A delegate to configure the <see cref="Html"/> element before it is added as a child.</param>
    /// <returns>The parent element with the newly added <see cref="Html"/> child element.</returns>
    public static DoubleHtmlElementWithChildren Html(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Html> action)
    {
        Html tag = new Html();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
