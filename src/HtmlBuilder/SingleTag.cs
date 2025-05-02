using System.Text;

namespace HtmlBuilder;
/// <summary>
/// Represents a single HTML tag that does not have a closing tag (e.g., <img />, <br />).
/// </summary>
public class SingleTag : BaseTag
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SingleTag"/> class with the specified tag name.
    /// </summary>
    /// <param name="name">The name of the HTML tag.</param>
    protected SingleTag(string name) : base(name)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SingleTag"/> class with the specified tag name
    /// and an action to configure the tag.
    /// </summary>
    /// <param name="name">The name of the HTML tag.</param>
    /// <param name="action">An action to configure the tag.</param>
    protected SingleTag(string name, Action<SingleTag> action) : base(name)
    {
        action?.Invoke(this);
    }

    /// <summary>
    /// Renders the HTML representation of the single tag with the specified indentation level.
    /// </summary>
    /// <param name="level">The indentation level for the rendered tag.</param>
    /// <returns>A string containing the rendered HTML tag.</returns>
    public override string Render(int level)
    {
        var indent = new string(' ', level * 4);
        var sb = new StringBuilder();
        sb.Append($"{indent}<{Name}");
        sb.Append(RenderAttributes());
        sb.AppendLine("/>");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the string representation of the single tag.
    /// </summary>
    /// <returns>A string containing the rendered HTML tag with no indentation.</returns>
    public override string ToString()
    {
        return Render(0);
    }
}
