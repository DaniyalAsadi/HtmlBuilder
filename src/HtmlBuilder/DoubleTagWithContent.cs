using System.Text;

namespace HtmlBuilder;


/// <summary>
/// Represents an HTML tag that has both opening and closing tags, and contains content between them.
/// </summary>
public class DoubleTagWithContent : DoubleTag
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DoubleTagWithContent"/> class.
    /// </summary>
    /// <param name="name">The name of the HTML tag.</param>
    /// <param name="content">The content to be placed inside the tag. Defaults to an empty string.</param>
    /// <param name="action">An optional action to configure the tag during initialization.</param>
    protected DoubleTagWithContent(string name, string content = "", Action<DoubleTagWithContent>? action = null) :
        base(name)
    {
        action?.Invoke(this);
        Content = content;
    }

    /// <summary>
    /// Gets the content of the tag.
    /// </summary>
    public string Content { get; private set; }

    /// <summary>
    /// Updates the content of the tag.
    /// </summary>
    /// <param name="content">The new content to set.</param>
    /// <returns>The updated content.</returns>
    public string AddContent(string content)
    {
        Content = content;
        return Content;
    }

    /// <summary>
    /// Renders the HTML representation of the tag, including its content and attributes.
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
    /// Returns the string representation of this tag, including its children.
    /// </summary>
    /// <returns>A string containing the rendered HTML.</returns>
    public override string ToString()
    {
        return Render(0);
    }
}
