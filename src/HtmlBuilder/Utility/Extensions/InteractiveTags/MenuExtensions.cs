using System;

namespace HtmlBuilder.Tags.InteractiveTags;
/// <summary>
/// Provides extension methods for configuring and manipulating <see cref="Menu"/> elements within an HTML structure.
/// </summary>
/// <remarks>This static class contains methods to simplify the creation and customization of <see cref="Menu"/> 
/// elements, allowing for fluent configuration and integration with parent elements.</remarks>
public static class MenuExtensions
{
    /// <summary>
    /// Sets the type of the specified <see cref="Menu"/> and returns the updated instance.
    /// </summary>
    /// <param name="tag">The <see cref="Menu"/> instance to update.</param>
    /// <param name="type">The type to assign to the <see cref="Menu"/>. Cannot be <see langword="null"/> or empty.</param>
    /// <returns>The updated <see cref="Menu"/> instance with the specified type set.</returns>
    public static Menu SetType(this Menu tag, string type)
    {
        tag.SetType(type);
        return tag;
    }

    /// <summary>
    /// Sets the label for the specified <see cref="Menu"/> instance.
    /// </summary>
    /// <param name="tag">The <see cref="Menu"/> instance to update.</param>
    /// <param name="label">The label to assign to the <see cref="Menu"/> instance. Cannot be <see langword="null"/> or empty.</param>
    /// <returns>The updated <see cref="Menu"/> instance.</returns>
    public static Menu SetLabel(this Menu tag, string label)
    {
        tag.SetLabel(label);
        return tag;
    }

    /// <summary>
    /// Adds a <see cref="Menu"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="Menu"/> element through the provided action.
    /// </summary>
    /// <remarks>This method creates a new <see cref="Menu"/> element, applies the specified configuration
    /// action to it,  and appends it as a child to the current <see cref="DoubleHtmlElementWithChildren"/>.  Use this
    /// method to dynamically construct and configure a menu within an HTML structure.</remarks>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Menu"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="Menu"/> element before it is added as a child.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Menu(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Menu> action)
    {
        Menu tag = new Menu();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
