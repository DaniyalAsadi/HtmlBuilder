using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo(assemblyName: "HtmlBuilder.Tests")]

namespace HtmlBuilder;


/// <summary>
/// Represents the base class for an HTML htmlElement.
/// Provides common functionality for managing attributes and classes.
/// </summary>
/// <param name="name">The name of the HTML htmlElement.</param>
public abstract class HtmlElement(string name) : IHtmlElement
{
    /// <summary>
    /// Gets the name of the HTML htmlElement.
    /// </summary>
    public string Name { get; } = name;

    /// <summary>
    /// Gets the collection of attributes for the HTML htmlElement.
    /// </summary>
    protected internal Dictionary<string, string?> Attributes { get; } = new();

    /// <summary>
    /// Gets the collection of CSS classes for the HTML htmlElement.
    /// </summary>
    protected internal HashSet<string> Classes { get; } = new();

    /// <summary>
    /// Adds an attribute to the HTML htmlElement.
    /// </summary>
    /// <param name="key">The name of the attribute.</param>
    /// <param name="value">The value of the attribute. Defaults to null.</param>
    /// <returns>The current instance of the htmlElement.</returns>
    public HtmlElement AddAttribute(string key, string? value = null)
    {
        Attributes[key] = value;
        return this;
    }

    public abstract void Accept(IHtmlVisitor visitor);

    /// <summary>
    /// Renders the attributes of the HTML htmlElement as a string.
    /// </summary>
    /// <returns>A string containing the rendered attributes.</returns>
    protected internal string RenderAttributes()
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
    /// Adds multiple attributes to the HTML htmlElement.
    /// </summary>
    /// <param name="attributes">A collection of key-value pairs representing the attributes.</param>
    /// <returns>The current instance of the htmlElement.</returns>
    public HtmlElement AddAttributes(IEnumerable<KeyValuePair<string, string?>> attributes)
    {
        foreach (var attribute in attributes) AddAttribute(attribute.Key, attribute.Value);
        return this;
    }

    /// <summary>
    /// Sets the ID attribute of the HTML htmlElement.
    /// </summary>
    /// <param name="id">The ID value to set.</param>
    /// <returns>The current instance of the htmlElement.</returns>
    public HtmlElement SetId(string id)
    {
        Attributes["id"] = id;
        return this;
    }

    /// <summary>
    /// Adds a CSS class to the HTML htmlElement.
    /// </summary>
    /// <param name="class">The CSS class to add.</param>
    /// <returns>The current instance of the htmlElement.</returns>
    public HtmlElement AddClass(string @class)
    {
        Classes.Add(@class);
        return this;
    }

}

