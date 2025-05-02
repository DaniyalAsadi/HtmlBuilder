namespace HtmlBuilder.Tags;

/// <summary>
/// Represents an HTML &lt;select&gt; tag, which allows the creation of a dropdown menu with selectable options.
/// </summary>
/// <remarks>
/// This class provides functionality to manage child <see cref="Option"/> tags and allows setting a selected option
/// based on a specified value. It inherits from <see cref="DoubleTagWithChildren"/>, enabling it to contain child tags.
/// </remarks>
public class Select() : DoubleTagWithChildren("select")
{
    /// <summary>
    /// Sets the selected option in the dropdown menu based on the specified value.
    /// </summary>
    /// <param name="value">The value of the option to be selected.</param>
    /// <remarks>
    /// This method iterates through the child <see cref="Option"/> tags and sets the one with a matching "key" attribute
    /// as selected. If no matching option is found, no changes are made.
    /// </remarks>
    public void SetSelected(string value)
    {
        foreach (var option in Children.OfType<Option>())
        {
            if (option.GetAttribute("key") != value) continue;
            option.SetSelected();
            break;
        }
    }
}
