using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.FormTags;
public class Input() : SingleTag("input")
{
    public InputType Type { get; set; }

    internal void SetType(InputType type)
    {
        this.Type = type;
        this.AddAttribute("type", type.ToHtmlString());
    }

    internal void SetValue(string defaultValue)
    {
        this.AddAttribute("value", defaultValue);
    }

    internal void AddRegex(string regex)
    {
        this.AddAttribute("pattern", regex);
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}