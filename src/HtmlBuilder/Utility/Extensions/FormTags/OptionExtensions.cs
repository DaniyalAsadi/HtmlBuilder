namespace HtmlBuilder.Tags.FormTags;
/// <summary>
/// Provides extension methods for working with <see cref="Option"/> and <see cref="DoubleHtmlElementWithChildren"/>
/// instances.
/// </summary>
/// <remarks>The <see cref="OptionExtensions"/> class includes methods for configuring and manipulating <see
/// cref="Option"/> elements, as well as adding them to parent <see cref="DoubleHtmlElementWithChildren"/> instances.
/// These methods are designed to support fluent method chaining, enabling concise and expressive code for building and
/// customizing HTML structures.</remarks>
public static class OptionExtensions
{
    /// <summary>
    /// Sets the value of the specified <see cref="Option"/> and returns the updated instance.
    /// </summary>
    /// <remarks>This method updates the value of the provided <see cref="Option"/> instance and returns the
    /// same instance to allow for method chaining.</remarks>
    /// <param name="tag">The <see cref="Option"/> instance to update.</param>
    /// <param name="value">The value to set for the <see cref="Option"/>.</param>
    /// <returns>The updated <see cref="Option"/> instance.</returns>
    public static Option SetValue(this Option tag, string value)
    {
        tag.SetValue(value);
        return tag;
    }

    /// <summary>
    /// Marks the specified <see cref="Option"/> as selected and returns the updated instance.
    /// </summary>
    /// <param name="tag">The <see cref="Option"/> instance to mark as selected.</param>
    /// <returns>The same <see cref="Option"/> instance with the selected state applied.</returns>
    public static Option SetSelected(this Option tag)
    {
        tag.SetSelected();
        return tag;
    }

    /// <summary>
    /// Sets the <see cref="Option"/> instance to a disabled state and returns the updated instance.
    /// </summary>
    /// <param name="tag">The <see cref="Option"/> instance to be disabled.</param>
    /// <returns>The same <see cref="Option"/> instance with the disabled state applied.</returns>
    public static Option SetDisabled(this Option tag)
    {
        tag.SetDisabled();
        return tag;
    }

    /// <summary>
    /// Retrieves the attribute associated with the specified key from the given <see cref="Option"/> instance.
    /// </summary>
    /// <remarks>This method retrieves the attribute associated with the specified key and returns the same
    /// <see cref="Option"/> instance. It is designed to support fluent method chaining.</remarks>
    /// <param name="tag">The <see cref="Option"/> instance from which to retrieve the attribute.</param>
    /// <param name="key">The key of the attribute to retrieve. Cannot be <see langword="null"/> or empty.</param>
    /// <returns>The <see cref="Option"/> instance, allowing for method chaining.</returns>
    public static Option GetAttribute(this Option tag, string key)
    {
        tag.GetAttribute(key);
        return tag;
    }

    /// <summary>
    /// Adds an <see cref="Option"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Option"/> element through the specified action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Option"/> element, applies the provided configuration
    /// action to it,  and appends it as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>.  Use this
    /// method to dynamically build and configure HTML structures.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Option"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <see cref="Option"/> element.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Option(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Option> action)
    {
        Option tag = new Option();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
