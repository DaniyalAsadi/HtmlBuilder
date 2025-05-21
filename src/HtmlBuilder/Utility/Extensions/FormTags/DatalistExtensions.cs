using System;

namespace HtmlBuilder.Tags.FormTags;
/// <summary>
/// Adds a <c>&lt;datalist&gt;</c> element as a child to the current HTML element and allows customization of the
/// <c>&lt;datalist&gt;</c> element.
/// </summary>
/// <remarks>This method creates a <c>&lt;datalist&gt;</c> element, configures it using the provided <paramref
/// name="action"/>,  and appends it to the specified parent HTML element. The <c>&lt;datalist&gt;</c> element is
/// typically used to provide  a list of predefined options for an input element.</remarks>
public static class DatalistExtensions
{
    /// <summary>
    /// Adds a <datalist> element as a child to the current HTML element and allows customization of the <datalist>
    /// element.
    /// </summary>
    /// <remarks>This method is used to create and configure a <datalist> element, which is then appended to
    /// the specified parent HTML element. The <paramref name="action"/> parameter allows the caller to define the
    /// content and attributes of the <datalist> element.</remarks>
    /// <param name="doubleHtmlElement">The parent HTML element to which the <datalist> element will be added.</param>
    /// <param name="action">An action that configures the <datalist> element. The action receives an instance of the <see cref="Datalist"/>
    /// class for customization.</param>
    /// <returns>The parent HTML element with the <datalist> element added as a child.</returns>
    public static DoubleHtmlElementWithChildren Datalist(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Datalist> action)
    {
        Datalist tag = new Datalist();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
