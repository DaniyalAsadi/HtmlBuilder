using System;

namespace HtmlBuilder.Tags.ScriptAndMetaTags;
/// <summary>
/// Adds a <c>&lt;noscript&gt;</c> element as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>  and
/// allows customization of the <c>&lt;noscript&gt;</c> element through the provided action.
/// </summary>
/// <remarks>The <c>&lt;noscript&gt;</c> element is used to define content that will be displayed if the user's
/// browser  does not support or has disabled JavaScript. This method facilitates adding and configuring such an element
/// within the context of a parent HTML element.</remarks>
public static class NoscriptExtensions
{
    /// <summary>
    /// Adds a <c>&lt;noscript&gt;</c> element as a child to the current HTML element and allows customization of its
    /// content.
    /// </summary>
    /// <remarks>The <c>&lt;noscript&gt;</c> element is used to define content that will be displayed if the
    /// user's browser does not support JavaScript. This method allows you to add such an element to the current HTML
    /// structure and customize its content using the provided <paramref name="action"/> delegate.</remarks>
    /// <param name="doubleHtmlElement">The parent HTML element to which the <c>&lt;noscript&gt;</c> element will be added.</param>
    /// <param name="action">An <see cref="Action{T}"/> delegate that configures the <c>&lt;noscript&gt;</c> element.</param>
    /// <returns>The parent HTML element with the <c>&lt;noscript&gt;</c> element added as a child.</returns>
    public static DoubleHtmlElementWithChildren Noscript(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Noscript> action)
    {
        Noscript tag = new Noscript();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
