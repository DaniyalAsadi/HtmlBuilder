namespace HtmlBuilder;

/// <summary>
/// Represents an HTML htmlElement with a name, attributes, and rendering functionality.
/// </summary>
public interface IHtmlElement
{
    /// <summary>
    /// Gets the name of the HTML htmlElement.
    /// </summary>
    string Name { get; }


    void Accept(IHtmlVisitor visitor);
}
