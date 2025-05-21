using System;

namespace HtmlBuilder.Tags.TextContentTag;
/// <summary>
/// Provides extension methods for working with <c>DoubleHtmlElementWithChildren</c> instances, enabling the addition
/// and configuration of <c>&lt;dt&gt;</c> elements.
/// </summary>
/// <remarks>The <c>&lt;dt&gt;</c> element represents a term in a description list. These extension methods
/// simplify the process of adding and configuring <c>&lt;dt&gt;</c> elements within a parent HTML structure.</remarks>
public static class DtExtensions
{
    /// <summary>
    /// Adds a <c>&lt;dt&gt;</c> element as a child to the current <c>DoubleHtmlElementWithChildren</c> instance and
    /// allows configuration of the <c>&lt;dt&gt;</c> element through the specified action.
    /// </summary>
    /// <remarks>The <c>&lt;dt&gt;</c> element represents a term in a description list. Use this method to add
    /// and configure a <c>&lt;dt&gt;</c> element within a parent HTML structure.</remarks>
    /// <param name="doubleHtmlElement">The parent <c>DoubleHtmlElementWithChildren</c> to which the <c>&lt;dt&gt;</c> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate to configure the <c>&lt;dt&gt;</c> element.</param>
    /// <returns>The modified <c>DoubleHtmlElementWithChildren</c> instance, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Dt(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Dt> action)
    {
        Dt tag = new Dt();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
