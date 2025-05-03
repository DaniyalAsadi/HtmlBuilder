
namespace HtmlBuilder.Tags;

public class Option : DoubleTagWithContent
{
    public Option() : base("option")
    {
    }

    public void SetSelected()
    {
        AddAttribute("selected");
    }

    public void SetValue(string value)
    {
        AddAttribute("value", value);
    }

    public string? GetAttribute(string key)
    {
        return Attributes.GetValueOrDefault(key);
    }
}