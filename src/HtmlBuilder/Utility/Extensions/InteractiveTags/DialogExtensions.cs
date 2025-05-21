namespace HtmlBuilder.Tags.InteractiveTags;
/// <summary>
/// Provides extension methods for working with <see cref="Dialog"/> elements in a fluent and customizable manner.
/// </summary>
/// <remarks>This static class contains methods to simplify the creation, configuration, and manipulation of <see
/// cref="Dialog"/> elements. The methods are designed to support fluent API usage, enabling method chaining and
/// streamlined workflows for building HTML structures.</remarks>
public static class DialogExtensions
{
    /// <summary>
    /// Sets the dialog to an open state and returns the updated dialog instance.
    /// </summary>
    /// <remarks>This method is a convenience extension method that modifies the state of the provided <see
    /// cref="Dialog"/>  instance and allows for method chaining by returning the same instance.</remarks>
    /// <param name="tag">The <see cref="Dialog"/> instance to set to an open state.</param>
    /// <returns>The same <see cref="Dialog"/> instance after being set to an open state.</returns>
    public static Dialog SetOpen(this Dialog tag)
    {
        tag.SetOpen();
        return tag;
    }

    /// <summary>
    /// Adds a <see cref="Dialog"/> element as a child to the current HTML element and allows customization of the
    /// dialog's content and attributes.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Dialog"/> element, applies the specified configuration
    /// action to it,  and appends it as a child to the provided parent element. The method supports fluent API
    /// usage.</remarks>
    /// <param name="doubleHtmlElement">The parent HTML element to which the <see cref="Dialog"/> element will be added.</param>
    /// <param name="action">A delegate that configures the <see cref="Dialog"/> element by setting its content and attributes.</param>
    /// <returns>The modified parent HTML element, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Dialog(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Dialog> action)
    {
        Dialog tag = new Dialog();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
