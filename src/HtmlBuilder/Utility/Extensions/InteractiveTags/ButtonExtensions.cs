using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.InteractiveTags;
/// <summary>
/// Provides extension methods for configuring and manipulating <see cref="Button"/> elements within an HTML structure.
/// </summary>
/// <remarks>These methods allow for fluent configuration of <see cref="Button"/> elements, enabling chaining and
/// concise syntax when building HTML structures programmatically. The extensions include methods for setting button
/// attributes, such as disabling the button, specifying its type, and assigning a value, as well as adding a configured
/// button to a parent element.</remarks>
public static class ButtonExtensions
{
    /// <summary>
    /// Sets the specified <see cref="Button"/> to a disabled state.
    /// </summary>
    /// <remarks>This method disables the provided <see cref="Button"/> and returns it for further
    /// configuration or chaining.</remarks>
    /// <param name="tag">The <see cref="Button"/> instance to be disabled.</param>
    /// <returns>The same <see cref="Button"/> instance, allowing for method chaining.</returns>
    public static Button SetDisabled(this Button tag)
    {
        tag.SetDisabled();
        return tag;
    }

    /// <summary>
    /// Sets the type of the button and returns the updated button instance.
    /// </summary>
    /// <param name="tag">The button instance to update.</param>
    /// <param name="type">The type to set for the button.</param>
    /// <returns>The updated button instance with the specified type applied.</returns>
    public static Button SetType(this Button tag, ButtonType type)
    {
        tag.SetType(type);
        return tag;
    }

    /// <summary>
    /// Sets the specified value on the button and returns the updated button instance.
    /// </summary>
    /// <param name="tag">The button instance on which the value will be set.</param>
    /// <param name="value">The value to set on the button.</param>
    /// <returns>The updated button instance with the specified value applied.</returns>
    public static Button SetValue(this Button tag, string value)
    {
        tag.SetValue(value);
        return tag;
    }

    /// <summary>
    /// Adds a <see cref="Button"/> element as a child to the current HTML element and allows customization of the
    /// button through the specified action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent HTML element to which the <see cref="Button"/> will be added.</param>
    /// <param name="action">An action to configure the <see cref="Button"/> element before it is added as a child.</param>
    /// <returns>The parent HTML element with the newly added <see cref="Button"/> child element.</returns>
    public static DoubleHtmlElementWithChildren Button(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Button> action)
    {
        Button tag = new Button();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
