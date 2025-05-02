using System.Text;

namespace HtmlBuilder;


/// <summary>
/// Represents the base class for an HTML tag.
/// Provides common functionality for managing attributes and classes.
/// </summary>
/// <param name="name">The name of the HTML tag.</param>
public abstract class BaseTag(string name) : ITag
{
    /// <summary>
    /// Gets the name of the HTML tag.
    /// </summary>
    public string Name { get; } = name;

    /// <summary>
    /// Gets the collection of attributes for the HTML tag.
    /// </summary>
    protected Dictionary<string, string?> Attributes { get; } = new();

    /// <summary>
    /// Gets the collection of CSS classes for the HTML tag.
    /// </summary>
    protected HashSet<string> Classes { get; } = new();

    /// <summary>
    /// Adds an attribute to the HTML tag.
    /// </summary>
    /// <param name="key">The name of the attribute.</param>
    /// <param name="value">The value of the attribute. Defaults to null.</param>
    /// <returns>The current instance of the tag.</returns>
    public ITag AddAttribute(string key, string? value = null)
    {
        Attributes[key] = value;
        return this;
    }

    /// <summary>
    /// Renders the HTML tag as a string.
    /// </summary>
    /// <param name="level">The indentation level for rendering.</param>
    /// <returns>The rendered HTML string.</returns>
    public abstract string Render(int level);

    /// <summary>
    /// Renders the attributes of the HTML tag as a string.
    /// </summary>
    /// <returns>A string containing the rendered attributes.</returns>
    protected string RenderAttributes()
    {
        var sb = new StringBuilder();
        foreach (var attribute in Attributes)
            if (attribute.Value is null)
                sb.Append($" {attribute.Key}");
            else
                sb.Append($" {attribute.Key}=\"{attribute.Value}\"");
        return sb.ToString();
    }

    /// <summary>
    /// Adds multiple attributes to the HTML tag.
    /// </summary>
    /// <param name="attributes">A collection of key-value pairs representing the attributes.</param>
    /// <returns>The current instance of the tag.</returns>
    public ITag AddAttributes(IEnumerable<KeyValuePair<string, string?>> attributes)
    {
        foreach (var attribute in attributes) AddAttribute(attribute.Key, attribute.Value);
        return this;
    }

    /// <summary>
    /// Sets the ID attribute of the HTML tag.
    /// </summary>
    /// <param name="id">The ID value to set.</param>
    /// <returns>The current instance of the tag.</returns>
    public ITag SetId(string id)
    {
        Attributes["id"] = id;
        return this;
    }

    /// <summary>
    /// Adds a CSS class to the HTML tag.
    /// </summary>
    /// <param name="class">The CSS class to add.</param>
    /// <returns>The current instance of the tag.</returns>
    public ITag AddClass(string @class)
    {
        Classes.Add(@class);
        return this;
    }
}
