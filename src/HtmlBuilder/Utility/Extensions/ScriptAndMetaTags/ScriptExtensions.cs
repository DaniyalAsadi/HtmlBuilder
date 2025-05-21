namespace HtmlBuilder.Tags.ScriptAndMetaTags;
/// <summary>
/// Provides extension methods for working with <see cref="Script"/> elements in an HTML generation context.
/// </summary>
/// <remarks>This class includes methods for configuring <see cref="Script"/> elements, such as setting attributes
/// like "src", "type", "async", and "defer". It also provides a method for adding a <see cref="Script"/> element as a
/// child to a <see cref="DoubleHtmlElementWithChildren"/>.</remarks>
public static class ScriptExtensions
{
    /// <summary>
    /// Sets the <c>src</c> attribute of the specified <see cref="Script"/> tag to the provided value.
    /// </summary>
    /// <param name="tag">The <see cref="Script"/> tag whose <c>src</c> attribute will be set.</param>
    /// <param name="src">The value to assign to the <c>src</c> attribute. Cannot be null or empty.</param>
    /// <returns>The updated <see cref="Script"/> tag with the <c>src</c> attribute set.</returns>
    public static Script SetSrc(this Script tag, string src)
    {
        tag.SetSrc(src);
        return tag;
    }

    /// <summary>
    /// Sets the type attribute of the specified <see cref="Script"/> tag.
    /// </summary>
    /// <param name="tag">The <see cref="Script"/> tag to modify.</param>
    /// <param name="type">The value to set for the type attribute. Cannot be null or empty.</param>
    /// <returns>The modified <see cref="Script"/> tag.</returns>
    public static Script SetType(this Script tag, string type)
    {
        tag.SetType(type);
        return tag;
    }

    /// <summary>
    /// Configures the specified <see cref="Script"/> instance to execute asynchronously.
    /// </summary>
    /// <param name="tag">The <see cref="Script"/> instance to configure for asynchronous execution.</param>
    /// <returns>The same <see cref="Script"/> instance, configured for asynchronous execution.</returns>
    public static Script SetAsync(this Script tag)
    {
        tag.SetAsync();
        return tag;
    }

    /// <summary>
    /// Sets the <c>defer</c> attribute on the specified <see cref="Script"/> tag and returns the updated tag.
    /// </summary>
    /// <remarks>The <c>defer</c> attribute indicates that the script should be executed after the document
    /// has been parsed, but before the <c>DOMContentLoaded</c> event. This is typically used for scripts that do not
    /// modify the DOM during parsing.</remarks>
    /// <param name="tag">The <see cref="Script"/> tag to modify.</param>
    /// <returns>The updated <see cref="Script"/> tag with the <c>defer</c> attribute set.</returns>
    public static Script SetDefer(this Script tag)
    {
        tag.SetDefer();
        return tag;
    }

    /// <summary>
    /// Adds a <see cref="Script"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Script"/> element through the provided action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Script"/> element, applies the specified configuration
    /// action to it,  and appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>.  Use this
    /// method to dynamically add and configure script elements in an HTML structure.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Script"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <see cref="Script"/> element.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Script(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Script> action)
    {
        Script tag = new Script();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
