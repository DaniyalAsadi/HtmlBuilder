namespace HtmlBuilder.Tags;

/// <summary>
/// Represents an HTML &lt;input&gt; tag.
/// </summary>
/// <remarks>
/// This class is used to generate an HTML &lt;input&gt; element, which is a single tag used for various types of user input.
/// </remarks>
public class Input() : SingleTag("input")
{
    /// <summary>
    /// Gets or sets the type of the input element.
    /// </summary>
    public InputType Type { get; set; }

    /// <summary>
    /// Sets the type of the input element.
    /// </summary>
    /// <param name="type">The <see cref="InputType"/> to set for the input element.</param>
    /// <returns>The current instance of the <see cref="Input"/> class.</returns>
    public Input SetType(InputType type)
    {
        Type = type;
        AddAttribute("type", type.ToString().ToLower());
        return this;
    }

    /// <summary>
    /// Sets the default value of the input element.
    /// </summary>
    /// <param name="defaultValue">The default value to set for the input element.</param>
    /// <returns>The current instance of the <see cref="Input"/> class.</returns>
    public Input SetValue(string defaultValue)
    {
        AddAttribute("value", defaultValue);
        return this;
    }

    /// <summary>
    /// Adds a regular expression pattern to validate the input value.
    /// </summary>
    /// <param name="regex">The regular expression pattern to set for the input element.</param>
    /// <returns>The current instance of the <see cref="Input"/> class.</returns>
    public Input AddRegex(string regex)
    {
        AddAttribute("pattern", regex);
        return this;
    }
}
