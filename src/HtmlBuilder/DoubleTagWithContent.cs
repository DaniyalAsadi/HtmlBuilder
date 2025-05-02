using System.Text;

namespace HtmlBuilder;

/// <summary>
///     <h1>hello</h1>
/// </summary>
public class DoubleTagWithContent : DoubleTag
{
    public DoubleTagWithContent(string name, string content = "", Action<DoubleTagWithContent>? action = null) :
        base(name)
    {
        action?.Invoke(this);
        Content = content;
    }

    public string Content { get; set; } = string.Empty;

    public string AddContent(string content)
    {
        Content = content;
        return Content;
    }

    public override string Render(int level)
    {
        var indent = new string(' ', level * 4);
        var sb = new StringBuilder();
        sb.Append($"{indent}<{Name}");
        foreach (var attribute in Attributes) sb.Append($" {attribute.Key}=\"{attribute.Value}\"");
        sb.Append("> ");

        if (!string.IsNullOrEmpty(Content)) sb.Append($"{Content} ");
        //sb.Append($"{new string(' ', (level + 1) * 4)}{Content}");
        sb.AppendLine($"</{Name}>");
        //sb.AppendLine($"{indent}</{Name}>");
        return sb.ToString();
    }
}