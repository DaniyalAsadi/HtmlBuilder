using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.FormTags;
/// <summary>
/// Provides extension methods for configuring and manipulating <see cref="Input"/> elements  and their integration
/// within <see cref="DoubleHtmlElementWithChildren"/> instances.
/// </summary>
/// <remarks>The <see cref="InputExtensions"/> class includes methods for setting properties, adding validation
/// rules,  and dynamically constructing <see cref="Input"/> elements within parent HTML elements. These methods  are
/// designed to support method chaining for fluent API usage.</remarks>
public static class InputExtensions
{
    /// <summary>
    /// Sets the type of the specified <see cref="Input"/> element and returns the updated element.
    /// </summary>
    /// <param name="tag">The <see cref="Input"/> element to update.</param>
    /// <param name="type">The <see cref="InputType"/> to set for the <paramref name="tag"/> element.</param>
    /// <returns>The updated <see cref="Input"/> element with the specified type set.</returns>
    public static Input SetType(this Input tag, InputType type)
    {
        tag.SetType(type);
        return tag;
    }

    /// <summary>
    /// Sets the value of the specified <see cref="Input"/> tag to the provided default value.
    /// </summary>
    /// <remarks>This method updates the value of the <paramref name="tag"/> and returns the same instance, 
    /// allowing for method chaining.</remarks>
    /// <param name="tag">The <see cref="Input"/> tag whose value will be set.</param>
    /// <param name="defaultValue">The default value to assign to the <paramref name="tag"/>.</param>
    /// <returns>The updated <see cref="Input"/> tag with the specified value set.</returns>
    public static Input SetValue(this Input tag, string defaultValue)
    {
        tag.SetValue(defaultValue);
        return tag;
    }

    /// <summary>
    /// Adds a regular expression validation rule to the specified <see cref="Input"/> tag.
    /// </summary>
    /// <param name="tag">The <see cref="Input"/> instance to which the regular expression validation rule will be added.</param>
    /// <param name="regex">The regular expression pattern to validate input against. Cannot be <see langword="null"/> or empty.</param>
    /// <returns>The <see cref="Input"/> instance with the added validation rule, allowing for method chaining.</returns>
    public static Input AddRegex(this Input tag, string regex)
    {
        tag.AddRegex(regex);
        return tag;
    }

    /// <summary>
    /// Adds an <see cref="Input"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Input"/> element through the specified action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Input"/> element, applies the specified configuration
    /// action to it,  and appends it as a child to the provided <see cref="DoubleHtmlElementWithChildren"/> instance. 
    /// Use this method to dynamically construct and configure HTML input elements within a parent element.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Input"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <see cref="Input"/> element before it is added to the
    /// parent.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Input(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Input> action)
    {
        Input tag = new Input();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
