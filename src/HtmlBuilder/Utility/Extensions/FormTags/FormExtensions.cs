using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.FormTags;
/// <summary>
/// Provides extension methods for configuring and manipulating <see cref="Form"/> elements within an HTML structure.
/// </summary>
/// <remarks>The <see cref="FormExtensions"/> class includes methods for setting common attributes of <see
/// cref="Form"/> elements, such as action URLs, HTTP methods, encryption types, and targets. It also provides
/// functionality for dynamically adding and configuring <see cref="Form"/> elements as children of other HTML elements.
/// These methods are designed to support method chaining, enabling fluent configuration of <see cref="Form"/>
/// elements.</remarks>
public static class FormExtensions
{
    /// <summary>
    /// Sets the action URL for the specified <see cref="Form"/> and returns the updated form.
    /// </summary>
    /// <param name="tag">The <see cref="Form"/> instance to update.</param>
    /// <param name="action">The action URL to set for the form. This value cannot be null or empty.</param>
    /// <returns>The updated <see cref="Form"/> instance with the specified action URL.</returns>
    public static Form SetAction(this Form tag, string action)
    {
        tag.SetAction(action);
        return tag;
    }

    /// <summary>
    /// Sets the HTTP method for the specified form and returns the updated form.
    /// </summary>
    /// <param name="tag">The <see cref="Form"/> instance to update.</param>
    /// <param name="method">The HTTP method to set for the form, such as <see cref="FormMethod.Get"/> or <see cref="FormMethod.Post"/>.</param>
    /// <returns>The updated <see cref="Form"/> instance with the specified HTTP method applied.</returns>
    public static Form SetMethod(this Form tag, FormMethod method)
    {
        tag.SetMethod(method);
        return tag;
    }

    /// <summary>
    /// Sets the encryption type for the specified <see cref="Form"/> and returns the updated instance.
    /// </summary>
    /// <remarks>This method allows chaining by returning the same <see cref="Form"/> instance after setting
    /// the encryption type.</remarks>
    /// <param name="tag">The <see cref="Form"/> instance to configure.</param>
    /// <param name="encryptType">The encryption type to apply to the form.</param>
    /// <returns>The <see cref="Form"/> instance with the specified encryption type applied.</returns>
    public static Form SetEncryptType(this Form tag, FormEncryptType encryptType)
    {
        tag.SetEncryptType(encryptType);
        return tag;
    }

    /// <summary>
    /// Sets the target for the specified <see cref="Form"/> and returns the updated form.
    /// </summary>
    /// <param name="tag">The <see cref="Form"/> instance to update.</param>
    /// <param name="target">The <see cref="FormTarget"/> to set for the form.</param>
    /// <returns>The updated <see cref="Form"/> instance with the specified target applied.</returns>
    public static Form SetTarget(this Form tag, FormTarget target)
    {
        tag.SetTarget(target);
        return tag;
    }

    /// <summary>
    /// Sets the "novalidate" attribute on the specified <see cref="Form"/> element,  indicating that the form should
    /// bypass HTML5 validation when submitted.
    /// </summary>
    /// <param name="tag">The <see cref="Form"/> element to modify.</param>
    /// <returns>The modified <see cref="Form"/> element, allowing for method chaining.</returns>
    public static Form SetNoValidate(this Form tag)
    {
        tag.SetNoValidate();
        return tag;
    }

    /// <summary>
    /// Adds a <see cref="Form"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Form"/> element through the provided action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Form"/> element, applies the specified configuration
    /// action to it,  and appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>.  Use this
    /// method to dynamically construct and configure form elements within an HTML structure.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Form"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <see cref="Form"/> element before it is added to the
    /// parent.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Form(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Form> action)
    {
        Form tag = new Form();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
