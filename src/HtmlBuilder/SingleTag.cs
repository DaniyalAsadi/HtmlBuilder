using System.Text;

namespace HtmlBuilder;

/// <summary>
///     <hr />
/// </summary>
public class SingleTag : BaseTag
{
    public SingleTag(string name, Action<SingleTag>? action = null) : base(name)
    {
        action?.Invoke(this);
    }

    public override string Render(int level)
    {
        var indent = new string(' ', level * 4);
        var sb = new StringBuilder();
        sb.Append($"{indent}<{Name}");

        foreach (var attribute in Attributes) sb.Append($" {attribute.Key}=\"{attribute.Value}\"");

        sb.AppendLine("/>");
        return sb.ToString();
    }
}