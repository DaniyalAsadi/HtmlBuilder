namespace HtmlBuilder.Tags.StructuralTags;
/// <summary>
/// Provides extension methods for working with HTML elements, including methods for adding and configuring <see
/// cref="Div"/> elements.
/// </summary>
/// <remarks>This class contains static methods that extend the functionality of <see
/// cref="DoubleHtmlElementWithChildren"/> by enabling the addition and customization of <see cref="Div"/> elements as
/// child elements.</remarks>
public static class DivExtensions
{
    /// <summary>
    /// Adds a <see cref="Div"/> element as a child to the current HTML element and allows customization of the <see
    /// cref="Div"/> element.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Div"/> element, applies the specified configuration
    /// action to it,  and then appends it as a child to the specified parent HTML element.</remarks>
    /// <param name="doubleHtmlElement">The parent HTML element to which the <see cref="Div"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <see cref="Div"/> element before it is added to the
    /// parent.</param>
    /// <returns>The updated parent HTML element with the newly added <see cref="Div"/> child element.</returns>
    public static DoubleHtmlElementWithChildren Div(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Div> action)
    {
        Div tag = new Div();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
