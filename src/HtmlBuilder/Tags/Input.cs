
namespace HtmlBuilder.Tags;

public class Input() : SingleTag("input")
{
    public InputType Type { get; set; }


    public Input SetType(InputType type)
    {
        this.Type = type;
        this.AddAttribute("type", type.ToString().ToLower());
        return this;
    }

    public Input SetValue(string defaultValue)
    {
        this.AddAttribute("value", defaultValue);
        return this;
    }

    public Input AddRegex(string regex)
    {
        this.AddAttribute("pattern", regex);
        return this;
    }
}