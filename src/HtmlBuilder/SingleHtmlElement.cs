namespace HtmlBuilder;
/// <summary>
/// Represents a single HTML htmlElement that does not have a closing htmlElement (e.g., <img />, <br />).
/// </summary>
public abstract class SingleHtmlElement(string name) : HtmlElement(name)
{
    /// <summary>
    /// Returns the string representation of the single htmlElement.
    /// </summary>
    /// <returns>A string containing the rendered HTML htmlElement with no indentation.</returns>
    public override string ToString()
    {
        return Name;
    }
}
