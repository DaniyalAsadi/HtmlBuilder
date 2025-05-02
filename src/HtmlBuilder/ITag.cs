namespace HtmlBuilder;

/// <summary>
/// Represents an HTML tag with a name, attributes, and rendering functionality.
/// </summary>
public interface ITag
{
    /// <summary>
    /// Gets the name of the HTML tag.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Adds an attribute to the HTML tag.
    /// </summary>
    /// <param name="key">The name of the attribute.</param>
    /// <param name="value">The value of the attribute.</param>
    /// <returns>The current instance of <see cref="ITag"/> for method chaining.</returns>
    ITag AddAttribute(string key, string value);

    /// <summary>
    /// Renders the HTML tag as a string.
    /// </summary>
    /// <param name="level">The indentation level for the rendered tag.</param>
    /// <returns>A string representation of the HTML tag.</returns>
    string Render(int level);
}
