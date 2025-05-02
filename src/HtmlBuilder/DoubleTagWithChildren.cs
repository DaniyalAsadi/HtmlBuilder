using System.Text;

namespace HtmlBuilder;

/// <summary>
///     <div>
///         <h1></h1>
///     </div>
/// </summary>
public class DoubleTagWithChildren : DoubleTag
{
    private readonly List<ITag> _children = new();

    public DoubleTagWithChildren(string name) : base(name)
    {
    }

    protected IEnumerable<ITag> Children => _children.AsReadOnly();

    public DoubleTagWithChildren AddChild<TTag>(Action<TTag>? creator = null)
        where TTag : ITag
    {
        var x = Activator.CreateInstance<TTag>();
        creator?.Invoke(x);
        _children.Add(x);
        return this;
    }

    public DoubleTagWithChildren AddChild<TTag>(ITag tag)
        where TTag : ITag
    {
        _children.Add(tag);
        return this;
    }

    public DoubleTagWithChildren AddChildren(IEnumerable<ITag> children)
    {
        _children.AddRange(children);
        return this;
    }

    public override string Render(int level)
    {
        var indent = new string(' ', level * 4);
        var sb = new StringBuilder();
        sb.Append($"{indent}<{Name}");
        foreach (var attribute in Attributes)
            if (attribute.Value is null)
                sb.Append($" {attribute.Key}");
            else
                sb.Append($" {attribute.Key}=\"{attribute.Value}\"");
        sb.AppendLine(">");

        foreach (var child in Children) sb.Append(child.Render(level + 1));

        sb.AppendLine($"{indent}</{Name}>");
        return sb.ToString();
    }

    public override string ToString()
    {
        return Render(0);
    }
}