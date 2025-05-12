namespace HtmlBuilder.Tags.FormTags;
public class Option() : DoubleTagWithContent("option")
{
    public string Value { get; private set; } = string.Empty;
    public bool IsSelected { get; private set; } = false;
    public bool IsDisabled { get; private set; } = false;

    internal void SetValue(string value)
    {
        this.Value = value;
        this.AddAttribute("value", value);
    }

    internal void SetSelected()
    {
        this.IsSelected = true;
        this.AddAttribute("selected");
    }

    internal void SetDisabled()
    {
        this.IsDisabled = true;
        this.AddAttribute("disabled");
    }

    internal string? GetAttribute(string key)
    {
        return this.Attributes.GetValueOrDefault(key);
    }
}
