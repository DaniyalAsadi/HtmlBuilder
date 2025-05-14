namespace HtmlBuilder;

/// <summary>
/// Represents an HTML htmlElement that can have child tags and attributes.
/// </summary>
public abstract class DoubleHtmlElementWithChildren(string name) : DoubleHtmlElement(name)
{
    /// <summary>
    /// The list of child tags contained within this htmlElement.
    /// </summary>
    private readonly List<HtmlElement> _children = new();
    /// <summary>
    /// Gets a read-only collection of child tags.
    /// </summary>
    public IEnumerable<HtmlElement> Children => _children.AsReadOnly();

    /// <summary>
    /// Adds a new child htmlElement of the specified type to this htmlElement.
    /// </summary>
    /// <typeparam name="TTag">The type of the child htmlElement to add.</typeparam>
    /// <param name="creator">An optional action to configure the child htmlElement.</param>
    /// <returns>The current <see cref="DoubleHtmlElementWithChildren"/> instance.</returns>
    public DoubleHtmlElementWithChildren AddChild<TTag>(Action<TTag>? creator = null)
        where TTag : HtmlElement, new()
    {
        var x = new TTag();
        creator?.Invoke(x);
        _children.Add(x);
        return this;
    }

    /// <summary>
    /// Adds an existing child htmlElement to this htmlElement.
    /// </summary>
    /// <param name="htmlElement">The child htmlElement to add.</param>
    /// <returns>The current <see cref="DoubleHtmlElementWithChildren"/> instance.</returns>
    public DoubleHtmlElementWithChildren AddChild(HtmlElement htmlElement)
    {
        _children.Add(htmlElement);
        return this;
    }



    /// <summary>
    /// Returns the string representation of this htmlElement, including its children.
    /// </summary>
    /// <returns>A string containing the rendered HTML.</returns>
    public override string ToString()
    {
        return Name;
    }
}
