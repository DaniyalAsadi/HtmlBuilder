using System;

namespace HtmlBuilder.Tags.StylingTags;
/// <summary>
/// Provides extension methods for working with <see cref="DoubleHtmlElementWithChildren"/> objects, enabling the
/// addition and customization of <see cref="U"/> elements.
/// </summary>
/// <remarks>The <see cref="UExtensions"/> class contains methods that simplify the creation and configuration of
/// <see cref="U"/> elements as children of <see cref="DoubleHtmlElementWithChildren"/> instances. These methods support
/// fluent method chaining for building HTML-like structures programmatically.</remarks>
public static class UExtensions
{
    /// <summary>
    /// Adds a new <see cref="U"/> element as a child to the current <see cref="DoubleHtmlElementWithChildren"/>  and
    /// allows customization of the <see cref="U"/> element through the provided action.
    /// </summary>
    /// <param name="doubleHtmlElement">The parent <see cref="DoubleHtmlElementWithChildren"/> to which the <see cref="U"/> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <see cref="U"/> element before it is added as a child.</param>
    /// <returns>The updated <see cref="DoubleHtmlElementWithChildren"/> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren U(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<U> action)
    {
        U tag = new U();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
