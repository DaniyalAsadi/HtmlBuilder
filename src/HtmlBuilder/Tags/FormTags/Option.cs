namespace HtmlBuilder.Tags.FormTags;

public class Option() : DoubleTagWithContent("option")
{
    public string Value { get; private set; } = string.Empty;
    public bool IsSelected { get; private set; } = false;
    public bool IsDisabled { get; private set; } = false;

    public Option SetValue(string value)
    {
        this.Value = value;
        this.AddAttribute("value", value);
        return this;
    }

    public Option SetSelected()
    {
        this.IsSelected = true;
        this.AddAttribute("selected");
        return this;
    }

    public Option SetDisabled()
    {
        this.IsDisabled = true;
        this.AddAttribute("disabled");
        return this;
    }

    public string? GetAttribute(string key)
    {
        return this.Attributes.GetValueOrDefault(key);
    }
}
