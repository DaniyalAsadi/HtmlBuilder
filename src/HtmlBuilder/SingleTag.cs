namespace HtmlBuilder;
/// <summary>
/// Represents a single HTML tag that does not have a closing tag (e.g., <img />, <br />).
/// </summary>
public abstract class SingleTag(string name) : BaseTag(name)
{
    /// <summary>
    /// Returns the string representation of the single tag.
    /// </summary>
    /// <returns>A string containing the rendered HTML tag with no indentation.</returns>
    public override string ToString()
    {
        return Name;
    }
}
