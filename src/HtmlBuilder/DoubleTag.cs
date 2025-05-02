using System.Text;

namespace HtmlBuilder;

/// <summary>
///     <h1></h1>
/// </summary>
public abstract class DoubleTag : BaseTag
{
    public DoubleTag(string name) : base(name)
    {
    }


    public override string Render(int level)
    {
        var indent = new string(' ', level * 4);
        var sb = new StringBuilder();
        sb.Append($"{indent}<{Name}");
        foreach (var attribute in Attributes)
            if (attribute.Value is not null)
                sb.Append($" {attribute.Key}=\"{attribute.Value}\"");
            else
                sb.Append($" {attribute.Key}");
        sb.AppendLine(">");

        sb.AppendLine($"{indent}</{Name}>");
        return sb.ToString();
    }
}