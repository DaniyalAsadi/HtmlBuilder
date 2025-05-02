using System.Text;

namespace HtmlBuilder;


/// <summary>
/// Represents an HTML tag that has both opening and closing tags, and contains raw text content between them.
/// </summary>
public abstract class SimpleDoubleTag : DoubleTag
{
    private string _content = string.Empty;

    protected SimpleDoubleTag(string name) : base(name)
    {

    }
    /// <summary>
    /// Initializes a new instance of the <see cref="SimpleDoubleTag"/> class.
    /// </summary>
    /// <param name="name">The name of the HTML tag.</param>
    /// <param name="action">An optional action to configure the tag during initialization.</param>
    protected SimpleDoubleTag(string name, Action<SimpleDoubleTag> action) : base(name)
    {
        action?.Invoke(this);
    }

    /// <summary>
    /// Gets the raw text content of the tag.
    /// </summary>
    public string Content => _content;

    /// <summary>
    /// Updates the raw text content of the tag.
    /// </summary>
    /// <param name="content">The new raw text content to set.</param>
    /// <returns>The updated content.</returns>
    public string SetContent(string content)
    {
        _content = content;
        return content;

    }

    /// <summary>
    /// Renders the HTML representation of the tag, including its raw text content and attributes.
    /// </summary>
    /// <param name="level">The indentation level for the rendered HTML.</param>
    /// <returns>A string containing the rendered HTML.</returns>
    public override string Render(int level)
    {
        var indent = new string(' ', level * 4);
        var sb = new StringBuilder();
        sb.Append($"{indent}<{Name}");
        sb.Append(RenderAttributes());
        sb.Append("> ");
        if (!string.IsNullOrEmpty(Content)) sb.Append($"{Content} ");
        sb.AppendLine($"</{Name}>");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the string representation of this tag, including its raw text content.
    /// </summary>
    /// <returns>A string containing the rendered HTML.</returns>
    public override string ToString()
    {
        return Render(0);
    }
}
