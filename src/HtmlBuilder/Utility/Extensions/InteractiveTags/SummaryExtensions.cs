using System;

namespace HtmlBuilder.Tags.InteractiveTags;
/// <summary>
/// Adds a <see cref="Summary"/> element as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>  and
/// allows customization of the <see cref="Summary"/> element through the provided action.
/// </summary>
/// <remarks>This method creates a new <see cref="Summary"/> element, applies the specified configuration action
/// to it,  and appends it as a child to the provided <see cref="DoubleHtmlElementWithChildren"/>.  Use this method to
/// add and customize a <see cref="Summary"/> element in a fluent API style.</remarks>
public static class SummaryExtensions
{
    /// <summary>
    /// Adds a <see cref="Summary"/> element as a child to the specified <see cref="DoubleHtmlElementWithChildren"/> 
    /// and allows customization of the <see cref="Summary"/> element through the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="Summary"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="Summary"/> element before it is added as a
    /// child.</param>
    /// <returns>The modified <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Summary(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Summary> action)
    {
        Summary tag = new Summary();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
