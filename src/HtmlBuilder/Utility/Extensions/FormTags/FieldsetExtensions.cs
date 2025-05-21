namespace HtmlBuilder.Tags.FormTags;
/// <summary>
/// Provides extension methods for working with <see cref="Fieldset"/> elements in an HTML structure.
/// </summary>
/// <remarks>This static class includes methods for setting attributes, modifying states, and adding <see
/// cref="Fieldset"/> elements to parent HTML elements. These methods are designed to simplify the creation and
/// customization of <see cref="Fieldset"/> elements in a fluent and intuitive manner.</remarks>
public static class FieldsetExtensions
{
    /// <summary>
    /// Sets the name attribute of the specified <see cref="Fieldset"/> tag.
    /// </summary>
    /// <param name="tag">The <see cref="Fieldset"/> instance to modify.</param>
    /// <param name="name">The value to assign to the name attribute. Cannot be null or empty.</param>
    /// <returns>The modified <see cref="Fieldset"/> instance, allowing for method chaining.</returns>
    public static Fieldset SetName(this Fieldset tag, string name)
    {
        tag.SetName(name);
        return tag;
    }
    
    /// <summary>
    /// Sets the form attribute of the specified <see cref="Fieldset"/> element.
    /// </summary>
    /// <param name="tag">The <see cref="Fieldset"/> element to modify.</param>
    /// <param name="form">The ID of the form element to associate with the <see cref="Fieldset"/>.</param>
    /// <returns>The modified <see cref="Fieldset"/> element.</returns>
    public static Fieldset SetForm(this Fieldset tag, string form)
    {
        tag.SetForm(form);
        return tag;
    }
    
    /// <summary>
    /// Sets the <see cref="Fieldset"/> element to a disabled state.
    /// </summary>
    /// <param name="tag">The <see cref="Fieldset"/> element to modify.</param>
    /// <returns>The same <see cref="Fieldset"/> instance with the disabled state applied.</returns>
    public static Fieldset SetDisabled(this Fieldset tag)
    {
        tag.SetDisabled();
        return tag;
    }

    /// <summary>
    /// Adds a <see cref="Fieldset"/> element as a child to the current HTML element and allows customization of the
    /// <see cref="Fieldset"/> element.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Fieldset"/> element, applies the specified configuration
    /// action to it,  and appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>
    /// instance.</remarks>
    /// <param name="doubleHtmlElement">The parent HTML element to which the <see cref="Fieldset"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <see cref="Fieldset"/> element.</param>
    /// <returns>The parent HTML element with the <see cref="Fieldset"/> element added as a child.</returns>
    public static DoubleHtmlElementWithChildren Fieldset(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Fieldset> action)
    {
        Fieldset tag = new Fieldset();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
