using System.Text;

namespace HtmlBuilder;

/// <summary>
/// Represents an HTML tag that can have child tags and attributes.
/// </summary>
public class CompositeDoubleTag : DoubleTag
{
    /// <summary>
    /// The list of child tags contained within this tag.
    /// </summary>
    private readonly List<object> _children = new();

    /// <summary>
    /// Represents an HTML tag that can have child tags and attributes.
    /// </summary>
    /// <param name="name">The name of the HTML tag.</param>
    protected CompositeDoubleTag(string name) : base(name)
    {
    }

    protected CompositeDoubleTag(string name, Action<CompositeDoubleTag> action) : base(name)
    {
        action.Invoke(this);
    }

    /// <summary>
    /// Gets a read-only collection of child tags.
    /// </summary>
    protected IEnumerable<object> Children => _children.AsReadOnly();

    /// <summary>
    /// Adds a new child tag of the specified type to this tag.
    /// </summary>
    /// <typeparam name="TTag">The type of the child tag to add.</typeparam>
    /// <param name="creator">An optional action to configure the child tag.</param>
    /// <returns>The current <see cref="CompositeDoubleTag"/> instance.</returns>
    public CompositeDoubleTag AddChild<TTag>(Action<TTag>? creator = null)
        where TTag : ITag, new()
    {
        var x = new TTag();
        creator?.Invoke(x);
        _children.Add(x);
        return this;
    }

    /// <summary>
    /// Adds an existing child tag to this tag.
    /// </summary>
    /// <param name="tag">The child tag to add.</param>
    /// <returns>The current <see cref="CompositeDoubleTag"/> instance.</returns>
    public CompositeDoubleTag AddChild(ITag tag)
    {
        _children.Add(tag);
        return this;
    }

    public CompositeDoubleTag AddText(string text)
    {
        _children.Add(text);
        return this;
    }

    /// <summary>
    /// Renders the HTML representation of this tag and its children.
    /// </summary>
    /// <param name="level">The indentation level for rendering.</param>
    /// <returns>A string containing the rendered HTML.</returns>
    public override string Render(int level)
    {
        var indent = new string(' ', level * 4);
        var sb = new StringBuilder();
        sb.Append($"{indent}<{Name}");
        sb.Append(RenderAttributes());
        sb.AppendLine(">");

        foreach (var child in Children)
        {
            if (child is string text)
            {
                sb.Append(text);
            }
            else if (child is BaseTag baseTag)
            {
                sb.Append(baseTag.Render(level + 1));
            }
        }

        sb.AppendLine($"{indent}</{Name}>");
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
