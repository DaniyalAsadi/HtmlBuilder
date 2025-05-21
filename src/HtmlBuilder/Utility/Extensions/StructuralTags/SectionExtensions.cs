using System;

namespace HtmlBuilder.Tags.StructuralTags;
/// <summary>
/// Adds a <see cref="Section"/> element as a child to the current HTML element and allows customization of the
/// section's content.
/// </summary>
/// <remarks>This method creates a new <see cref="Section"/> element, applies the specified configuration action
/// to it,  and appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/> instance.  It enables a
/// fluent API style by returning the updated parent element.</remarks>
public static class SectionExtensions
{
    /// <summary>
    /// Adds a <see cref="Section"/> element as a child to the current HTML element and allows customization of the
    /// section's content.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Section"/> element, applies the specified configuration
    /// action to it,  and appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>
    /// instance.</remarks>
    /// <param name="doubleHtmlElement">The parent HTML element to which the <see cref="Section"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <see cref="Section"/> element.</param>
    /// <returns>The updated <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Section(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Section> action)
    {
        Section tag = new Section();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
