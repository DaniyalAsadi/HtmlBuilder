using System;

namespace HtmlBuilder.Tags.ScriptAndMetaTags;
/// <summary>
/// Provides extension methods for configuring and adding <see cref="Link"/> elements to HTML structures.
/// </summary>
/// <remarks>This class includes methods for setting attributes on <see cref="Link"/> elements and for adding <see
/// cref="Link"/> elements as children to <see cref="DoubleHtmlElementWithChildren"/> instances. These methods are
/// designed to simplify the creation and configuration of <see cref="Link"/> elements in a fluent and expressive
/// manner.</remarks>
public static class LinkExtensions
{
    /// <summary>
    /// Sets the "rel" attribute of the specified <see cref="Link"/> instance to the provided value.
    /// </summary>
    /// <param name="tag">The <see cref="Link"/> instance to modify.</param>
    /// <param name="rel">The value to set for the "rel" attribute. Cannot be null or empty.</param>
    /// <returns>The modified <see cref="Link"/> instance, allowing for method chaining.</returns>
    public static Link SetRel(this Link tag, string rel)
    {
        tag.SetRel(rel);
        return tag;
    }

    /// <summary>
    /// Sets the type attribute of the specified <see cref="Link"/> tag and returns the updated tag.
    /// </summary>
    /// <param name="tag">The <see cref="Link"/> tag to update. Cannot be <see langword="null"/>.</param>
    /// <param name="type">The value to set for the type attribute. Cannot be <see langword="null"/> or empty.</param>
    /// <returns>The updated <see cref="Link"/> tag with the specified type attribute set.</returns>
    public static Link SetType(this Link tag, string type)
    {
        tag.SetType(type);
        return tag;
    }

    /// <summary>
    /// Sets the <c>href</c> attribute of the specified <see cref="Link"/> instance to the provided value.
    /// </summary>
    /// <param name="tag">The <see cref="Link"/> instance whose <c>href</c> attribute is to be set.</param>
    /// <param name="href">The value to assign to the <c>href</c> attribute. Cannot be <see langword="null"/> or empty.</param>
    /// <returns>The <see cref="Link"/> instance with the updated <c>href</c> attribute.</returns>
    public static Link SetHref(this Link tag, string href)
    {
        tag.SetHref(href);
        return tag;
    }

    /// <summary>
    /// Adds a <see cref="Link"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Link"/> element through the provided action.
    /// </summary>
    /// <remarks>This method enables fluent configuration of a <see cref="Link"/> element within the context
    /// of a parent  <see cref="DoubleHtmlElementWithChildren"/>. The <paramref name="action"/> parameter is used to
    /// customize  the <see cref="Link"/> element before it is added as a child.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Link"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <see cref="Link"/> element before it is added to the
    /// parent.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Link(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Link> action)
    {
        Link tag = new Link();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
