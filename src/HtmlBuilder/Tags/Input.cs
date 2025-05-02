namespace HtmlBuilder.Tags;

public class Input : SingleTag
{
    public Input() : base("input")
    {
    }

    public InputType Type { get; set; }


    public Input SetType(InputType type)
    {
        Type = type;
        AddAttribute("type", type.ToString().ToLower());
        return this;
    }

    public Input SetValue(string defaultValue)
    {
        AddAttribute("value", defaultValue);
        return this;
    }

    public Input AddRegex(string regex)
    {
        AddAttribute("pattern", regex);
        return this;
    }
}