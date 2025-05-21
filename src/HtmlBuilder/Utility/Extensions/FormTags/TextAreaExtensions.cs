namespace HtmlBuilder.Tags.FormTags;
/// <summary>
/// Provides extension methods for configuring and manipulating <see cref="Textarea"/> elements within an HTML
/// structure.
/// </summary>
/// <remarks>This static class contains methods to set various attributes and properties of a <see
/// cref="Textarea"/>  element, such as its name, placeholder, rows, columns, and state (e.g., required or disabled). 
/// It also includes a method to add a <see cref="Textarea"/> element as a child to a  <see
/// cref="DoubleHtmlElementWithChildren"/> instance.</remarks>
public static class TextAreaExtensions
{
    /// <summary>
    /// Sets the name attribute of the specified <see cref="Textarea"/> tag and returns the updated tag.
    /// </summary>
    /// <param name="tag">The <see cref="Textarea"/> instance to update.</param>
    /// <param name="name">The value to assign to the name attribute. Cannot be null or empty.</param>
    /// <returns>The updated <see cref="Textarea"/> instance with the specified name attribute set.</returns>
    public static Textarea SetName(this Textarea tag, string name)
    {
        tag.SetName(name);
        return tag;
    }

    /// <summary>
    /// Sets the placeholder text for the specified <see cref="Textarea"/> element.
    /// </summary>
    /// <param name="tag">The <see cref="Textarea"/> element to set the placeholder for.</param>
    /// <param name="placeholder">The placeholder text to display when the <see cref="Textarea"/> is empty.</param>
    /// <returns>The <see cref="Textarea"/> element with the updated placeholder text.</returns>
    public static Textarea SetPlaceholder(this Textarea tag, string placeholder)
    {
        tag.SetPlaceholder(placeholder);
        return tag;
    }

    /// <summary>
    /// Sets the number of visible text rows for the specified <see cref="Textarea"/> element.
    /// </summary>
    /// <param name="tag">The <see cref="Textarea"/> element to modify.</param>
    /// <param name="rows">The number of rows to display. Must be a positive integer.</param>
    /// <returns>The modified <see cref="Textarea"/> element.</returns>
    public static Textarea SetRows(this Textarea tag, int rows)
    {
        tag.SetRows(rows);
        return tag;
    }

    /// <summary>
    /// Sets the number of columns for the specified <see cref="Textarea"/> element.
    /// </summary>
    /// <param name="tag">The <see cref="Textarea"/> element to configure.</param>
    /// <param name="cols">The number of columns to set. Must be a positive integer.</param>
    /// <returns>The updated <see cref="Textarea"/> element, allowing for method chaining.</returns>
    public static Textarea SetCols(this Textarea tag, int cols)
    {
        tag.SetCols(cols);
        return tag;
    }

    /// <summary>
    /// Marks the <see cref="Textarea"/> element as required and returns the updated instance.
    /// </summary>
    /// <param name="tag">The <see cref="Textarea"/> element to be marked as required.</param>
    /// <returns>The updated <see cref="Textarea"/> instance with the required attribute set.</returns>
    public static Textarea SetRequired(this Textarea tag)
    {
        tag.SetRequired();
        return tag;
    }

    /// <summary>
    /// Sets the "disabled" attribute on the specified <see cref="Textarea"/> element.
    /// </summary>
    /// <param name="tag">The <see cref="Textarea"/> element to modify.</param>
    /// <returns>The modified <see cref="Textarea"/> element with the "disabled" attribute set.</returns>
    public static Textarea SetDisabled(this Textarea tag)
    {
        tag.SetDisabled();
        return tag;
    }

    /// <summary>
    /// Adds a <see cref="Textarea"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Textarea"/> element through a provided action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Textarea"/> element, applies the specified configuration
    /// action to it,  and appends it as a child to the provided <see cref="DoubleHtmlElementWithChildren"/>.  Use this
    /// method to dynamically construct and configure HTML structures.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Textarea"/> element will be
    /// added.</param>
    /// <param name="action">An <see cref="Action{Textarea}"/> delegate that configures the <see cref="Textarea"/> element.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Textarea(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Textarea> action)
    {
        Textarea tag = new Textarea();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
