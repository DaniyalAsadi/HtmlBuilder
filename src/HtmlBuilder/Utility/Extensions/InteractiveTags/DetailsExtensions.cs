namespace HtmlBuilder.Tags.InteractiveTags;
/// <summary>
/// Provides extension methods for working with <see cref="Details"/> elements in an HTML structure.
/// </summary>
/// <remarks>This static class contains methods to simplify the creation, configuration, and manipulation of <see
/// cref="Details"/> elements within an HTML document. These methods support method chaining and allow for dynamic
/// construction of HTML structures.</remarks>
public static class DetailsExtensions
{
    /// <summary>
    /// Sets the specified <see cref="Details"/> instance to an open state and returns the updated instance.
    /// </summary>
    /// <remarks>This method modifies the state of the provided <see cref="Details"/> instance by setting it
    /// to open. It then returns the same instance to allow for method chaining or further operations.</remarks>
    /// <param name="tag">The <see cref="Details"/> instance to modify.</param>
    /// <returns>The same <see cref="Details"/> instance after being set to an open state.</returns>
    public static Details SetOpen(this Details tag)
    {
        tag.SetOpen();
        return tag;
    }

    /// <summary>
    /// Adds a <see cref="Details"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Details"/> element through the provided action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Details"/> element, applies the specified configuration
    /// action to it,  and appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>.  Use this
    /// method to dynamically construct and configure a <see cref="Details"/> element within an HTML
    /// structure.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Details"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <see cref="Details"/> element.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Details(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Details> action)
    {
        Details tag = new Details();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
