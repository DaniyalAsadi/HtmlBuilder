namespace HtmlBuilder;
/// <summary>
/// Represents an HTML tag that contains raw text content.
/// </summary>
public class RawTextTag : BaseTag
{
    private readonly string _content;

    /// <summary>
    /// Initializes a new instance of the <see cref="RawTextTag"/> class with the specified tag name and content.
    /// </summary>
    /// <param name="content">The raw text content of the tag.</param>
    public RawTextTag(string content) : base("RawText")
    {
        _content = content;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RawTextTag"/> class with the specified tag name,
    /// content, and an action to configure the tag.
    /// </summary>
    /// <param name="content">The raw text content of the tag.</param>
    /// <param name="action">An action to configure the tag.</param>
    public RawTextTag(string content, Action<RawTextTag> action) : base("RawText")
    {
        _content = content;
        action.Invoke(this);
    }

    /// <summary>
    /// Renders the HTML representation of the raw text tag with the specified indentation level.
    /// </summary>
    /// <param name="level">The indentation level for the rendered tag.</param>
    /// <returns>A string containing the rendered HTML tag.</returns>
    public override string Render(int level)
    {
        var indent = new string(' ', level * 4);
        return indent + _content + Environment.NewLine;

    }

    /// <summary>
    /// Returns the string representation of the raw text tag.
    /// </summary>
    /// <returns>A string containing the rendered HTML tag with no indentation.</returns>
    public override string ToString()
    {
        return Render(0);
    }
}
