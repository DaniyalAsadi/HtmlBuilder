namespace HtmlBuilder;


/// <summary>
/// Represents an HTML htmlElement that has both opening and closing tags, and contains raw text content between them.
/// </summary>
public abstract class DoubleHtmlElementWithContent(string name) : DoubleHtmlElement(name)
{
    private string _content = string.Empty;

    /// <summary>
    /// Gets the raw text content of the htmlElement.
    /// </summary>
    public string Content => _content;

    /// <summary>
    /// Updates the raw text content of the htmlElement.
    /// </summary>
    /// <param name="content">The new raw text content to set.</param>
    /// <returns>The updated content.</returns>
    public DoubleHtmlElementWithContent SetContent(string content)
    {
        _content = content;
        return this;

    }


    /// <summary>
    /// Returns the string representation of this htmlElement, including its raw text content.
    /// </summary>
    /// <returns>A string containing the rendered HTML.</returns>
    public override string ToString()
    {
        return Name;
    }
}
