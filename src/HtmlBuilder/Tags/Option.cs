namespace HtmlBuilder.Tags;

/// <summary>
/// Represents an HTML &lt;option&gt; tag.
/// </summary>
/// <remarks>
/// This class is used to generate an HTML &lt;option&gt; element, which is used within a &lt;select&gt; element to define selectable options.
/// </remarks>
public class Option() : DoubleTagWithContent("option")
{
    /// <summary>
    /// Marks this option as selected by adding the "selected" attribute.
    /// </summary>
    public void SetSelected()
    {
        AddAttribute("selected");
    }

    /// <summary>
    /// Sets the value of the "value" attribute for this option.
    /// </summary>
    /// <param name="value">The value to set for the "value" attribute.</param>
    public void SetValue(string value)
    {
        AddAttribute("value", value);
    }

    /// <summary>
    /// Retrieves the value of a specified attribute.
    /// </summary>
    /// <param name="key">The name of the attribute to retrieve.</param>
    /// <returns>The value of the specified attribute, or <c>null</c> if the attribute does not exist.</returns>
    public string? GetAttribute(string key)
    {
        return Attributes.GetValueOrDefault(key);
    }
}
