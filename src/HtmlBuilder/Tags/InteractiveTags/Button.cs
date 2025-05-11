namespace HtmlBuilder.Tags.InteractiveTags;

public class Button() : DoubleTagWithContent("button")
{
    public bool IsDisabled { get; private set; } = false;
    public ButtonType Type { get; private set; } = ButtonType.Submit;
    public string Value { get; private set; } = string.Empty;

    public Button SetDisabled()
    {
        IsDisabled = true;
        AddAttribute("disabled");
        return this;
    }

    public Button SetType(ButtonType type)
    {
        Type = type;
        AddAttribute("type", type.ToString().ToLower());
        return this;
    }

    public Button SetValue(string value)
    {
        Value = value;
        AddAttribute("value", value);
        return this;
    }
}
