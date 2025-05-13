namespace HtmlBuilder;

/// <summary>
/// Represents an HTML tag that can have child tags and attributes.
/// </summary>
public abstract class DoubleTagWithChildren : DoubleTag
{
    /// <summary>
    /// The list of child tags contained within this tag.
    /// </summary>
    private readonly List<BaseTag> _children = new();

    /// <summary>
    /// Represents an HTML tag that can have child tags and attributes.
    /// </summary>
    /// <param name="name">The name of the HTML tag.</param>
    protected DoubleTagWithChildren(string name) : base(name)
    {
    }

    protected DoubleTagWithChildren(string name, Action<DoubleTagWithChildren> action) : base(name)
    {
        action.Invoke(this);
    }

    /// <summary>
    /// Gets a read-only collection of child tags.
    /// </summary>
    public IEnumerable<BaseTag> Children => _children.AsReadOnly();

    /// <summary>
    /// Adds a new child tag of the specified type to this tag.
    /// </summary>
    /// <typeparam name="TTag">The type of the child tag to add.</typeparam>
    /// <param name="creator">An optional action to configure the child tag.</param>
    /// <returns>The current <see cref="DoubleTagWithChildren"/> instance.</returns>
    public DoubleTagWithChildren AddChild<TTag>(Action<TTag>? creator = null)
        where TTag : BaseTag, new()
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
    /// <returns>The current <see cref="DoubleTagWithChildren"/> instance.</returns>
    public DoubleTagWithChildren AddChild(BaseTag tag)
    {
        _children.Add(tag);
        return this;
    }



    /// <summary>
    /// Returns the string representation of this tag, including its children.
    /// </summary>
    /// <returns>A string containing the rendered HTML.</returns>
    public override string ToString()
    {
        return Name;
    }
}
