using System;

namespace HtmlBuilder.Tags.TextContentTag;
/// <summary>
/// Provides extension methods for working with <see cref="Blockquote"/> elements in HTML structures.
/// </summary>
/// <remarks>These methods simplify the process of configuring and adding <see cref="Blockquote"/> elements to an
/// HTML structure, enabling a fluent and expressive API for building HTML content.</remarks>
public static class BlockquoteExtensions
{
    /// <summary>
    /// Sets the citation URL for the <see cref="Blockquote"/> element.
    /// </summary>
    /// <param name="tag">The <see cref="Blockquote"/> element to which the citation URL will be applied.</param>
    /// <param name="cite">The citation URL to associate with the <see cref="Blockquote"/> element. This value cannot be null or empty.</param>
    /// <returns>The updated <see cref="Blockquote"/> element with the specified citation URL.</returns>
    public static Blockquote SetCite(this Blockquote tag, string cite)
    {
        tag.SetCite(cite);
        return tag;
    }

    /// <summary>
    /// Adds a <c>&lt;blockquote&gt;</c> element as a child to the current HTML element and allows customization of the
    /// <c>&lt;blockquote&gt;</c> element.
    /// </summary>
    /// <remarks>This method creates a new <c>&lt;blockquote&gt;</c> element, applies the specified
    /// configuration action to it,  and appends it as a child to the current HTML element. Use this method to structure
    /// and customize  <c>&lt;blockquote&gt;</c> elements within your HTML document.</remarks>
    /// <param name="doubleHtmlElement">The parent HTML element to which the <c>&lt;blockquote&gt;</c> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <c>&lt;blockquote&gt;</c> element.</param>
    /// <returns>The parent HTML element with the newly added <c>&lt;blockquote&gt;</c> element.</returns>
    public static DoubleHtmlElementWithChildren Blockquote(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Blockquote> action)
    {
        Blockquote tag = new Blockquote();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
