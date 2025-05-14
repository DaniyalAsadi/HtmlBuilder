using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.InteractiveTags;
public class Button() : DoubleHtmlElementWithContent("button")
{
    public bool IsDisabled { get; private set; } = false;
    public ButtonType Type { get; private set; } = ButtonType.Submit;
    public string Value { get; private set; } = string.Empty;

    internal void SetDisabled()
    {
        IsDisabled = true;
        AddAttribute("disabled");
    }

    internal void SetType(ButtonType type)
    {
        Type = type;
        AddAttribute("type", type.ToHtmlString());
    }

    internal void SetValue(string value)
    {
        Value = value;
        AddAttribute("value", value);
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}