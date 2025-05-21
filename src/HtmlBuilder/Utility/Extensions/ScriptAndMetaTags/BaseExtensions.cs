using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.ScriptAndMetaTags;
/// <summary>
/// Provides extension methods for working with the <see cref="Base"/> HTML element.
/// </summary>
/// <remarks>This class includes methods for setting attributes on <see cref="Base"/> elements and for adding <see
/// cref="Base"/> elements as children to other HTML elements. These methods are designed to simplify the creation and
/// manipulation of <see cref="Base"/> elements in an HTML document.</remarks>
public static class BaseExtensions
{
    /// <summary>
    /// Sets the href attribute of the specified tag and returns the updated tag.
    /// </summary>
    /// <param name="tag">The tag to which the href attribute will be applied.</param>
    /// <param name="href">The value to set for the href attribute. This value cannot be null.</param>
    /// <returns>The updated tag with the href attribute set to the specified value.</returns>
    public static Base SetHref(this Base tag, string href)
    {
        tag.SetHref(href);
        return tag;
    }

    /// <summary>
    /// Sets the target for the specified <see cref="Base"/> instance and returns the updated instance.
    /// </summary>
    /// <remarks>This method allows for method chaining by returning the updated <see cref="Base"/>
    /// instance.</remarks>
    /// <param name="tag">The <see cref="Base"/> instance to update.</param>
    /// <param name="target">The <see cref="BaseTarget"/> to set as the target for the <paramref name="tag"/> instance.</param>
    /// <returns>The updated <see cref="Base"/> instance with the specified target set.</returns>
    public static Base SetTarget(this Base tag, BaseTarget target)
    {
        tag.SetTarget(target);
        return tag;
    }

    /// <summary>
    /// Adds a <see cref="Base"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Base"/> element through the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Base"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="Base"/> element before it is added to the
    /// parent.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> with the added <see cref="Base"/> element.</returns>
    public static DoubleHtmlElementWithChildren Base(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Base> action)
    {
        Base tag = new Base();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
