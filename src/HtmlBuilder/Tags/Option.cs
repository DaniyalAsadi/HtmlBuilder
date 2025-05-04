
namespace HtmlBuilder.Tags;

public class Option() : DoubleTagWithContent("option")
{
    public void SetSelected()
    {
        this.AddAttribute("selected");
    }

    public void SetValue(string value)
    {
        this.AddAttribute("value", value);
    }

    public string? GetAttribute(string key)
    {
        return this.Attributes.GetValueOrDefault(key);
    }
}