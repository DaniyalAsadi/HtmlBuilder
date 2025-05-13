namespace HtmlBuilder;


/// <summary>
/// Represents an HTML tag that has both opening and closing tags, and contains raw text content between them.
/// </summary>
public abstract class DoubleTagWithContent : DoubleTag
{
    private string _content = string.Empty;

    protected DoubleTagWithContent(string name) : base(name)
    {

    }
    /// <summary>
    /// Initializes a new instance of the <see cref="DoubleTagWithContent"/> class.
    /// </summary>
    /// <param name="name">The name of the HTML tag.</param>
    /// <param name="action">An optional action to configure the tag during initialization.</param>
    protected DoubleTagWithContent(string name, Action<DoubleTagWithContent> action) : base(name)
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
    public DoubleTagWithContent SetContent(string content)
    {
        _content = content;
        return this;

    }


    /// <summary>
    /// Returns the string representation of this tag, including its raw text content.
    /// </summary>
    /// <returns>A string containing the rendered HTML.</returns>
    public override string ToString()
    {
        return Name;
    }
}
