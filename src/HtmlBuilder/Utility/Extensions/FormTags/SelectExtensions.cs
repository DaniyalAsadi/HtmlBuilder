namespace HtmlBuilder.Tags.FormTags;
/// <summary>
/// Provides extension methods for configuring and manipulating <see cref="Select"/> elements  in a fluent and intuitive
/// manner.
/// </summary>
/// <remarks>The <see cref="SelectExtensions"/> class includes methods for setting attributes and properties  on
/// <see cref="Select"/> elements, such as name, required state, disabled state, and more.  These methods are designed
/// to simplify the creation and configuration of <see cref="Select"/>  elements when building HTML structures
/// programmatically.</remarks>
public static class SelectExtensions
{
    /// <summary>
    /// Sets the name attribute of the specified <see cref="Select"/> tag and returns the updated tag.
    /// </summary>
    /// <param name="tag">The <see cref="Select"/> tag to update.</param>
    /// <param name="name">The value to set for the name attribute. Cannot be null or empty.</param>
    /// <returns>The updated <see cref="Select"/> tag with the specified name attribute set.</returns>
    public static Select SetName(this Select tag, string name)
    {
        tag.SetName(name);
        return tag;
    }

    /// <summary>
    /// Marks the specified <see cref="Select"/> element as required, ensuring that a value must be selected.
    /// </summary>
    /// <remarks>This method modifies the <see cref="Select"/> element to enforce that a selection is required. It is
    /// typically used in scenarios where form validation requires a value to be selected from a dropdown or list.</remarks>
    /// <param name="tag">The <see cref="Select"/> element to be marked as required.</param>
    /// <returns>The same <see cref="Select"/> instance, allowing for method chaining.</returns>
    public static Select SetRequired(this Select tag)
    {
        tag.SetRequired();
        return tag;
    }

    /// <summary>
    /// Sets the "disabled" attribute on the specified <see cref="Select"/> tag.
    /// </summary>
    /// <param name="tag">The <see cref="Select"/> tag to modify.</param>
    /// <returns>The modified <see cref="Select"/> tag with the "disabled" attribute set.</returns>
    public static Select SetDisabled(this Select tag)
    {
        tag.SetDisabled();
        return tag;
    }

    /// <summary>
    /// Enables the selection of multiple options in the specified <see cref="Select"/> element.
    /// </summary>
    /// <remarks>This method sets the "multiple" attribute on the <see cref="Select"/> element, enabling users
    /// to select more than one option.</remarks>
    /// <param name="tag">The <see cref="Select"/> element to configure for multiple selection.</param>
    /// <returns>The same <see cref="Select"/> element, allowing for method chaining.</returns>
    public static Select SetMultiple(this Select tag)
    {
        tag.SetMultiple();
        return tag;
    }

    /// <summary>
    /// Sets the selected value for the specified <see cref="Select"/> tag and returns the updated tag.
    /// </summary>
    /// <param name="tag">The <see cref="Select"/> tag to update.</param>
    /// <param name="value">The value to set as selected in the <see cref="Select"/> tag.</param>
    /// <returns>The updated <see cref="Select"/> tag with the specified value set as selected.</returns>
    public static Select SetSelected(this Select tag, string value)
    {
        tag.SetSelected(value);
        return tag;
    }

    /// <summary>
    /// Adds a <see cref="Select"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Select"/> element through the provided action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Select"/> element, applies the specified configuration
    /// action to it,  and appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>.  Use this
    /// method to dynamically build and configure HTML structures.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Select"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <see cref="Select"/> element.</param>
    /// <returns>The updated <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Select(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Select> action)
    {
        Select tag = new Select();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
