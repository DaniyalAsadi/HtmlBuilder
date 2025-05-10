
namespace HtmlBuilder.Tags.FormTags;
public class Input() : SingleTag("input")
{
    public InputType Type { get; private set; } = InputType.Text;
    public string InputName { get; private set; } = string.Empty;
    public string Value { get; private set; } = string.Empty;
    public string Placeholder { get; private set; } = string.Empty;
    public bool IsRequired { get; private set; } = false;
    public bool IsDisabled { get; private set; } = false;


    public Input SetType(InputType type)
    {
        this.Type = type;
        this.AddAttribute("type", type.ToString().ToLower());
        return this;
    }

    public Input SetName(string name)
    {
        this.InputName = name;
        this.AddAttribute("name", name);
        return this;
    }

    public Input SetValue(string Value)
    {
        this.Value = Value;
        this.AddAttribute("value", Value);
        return this;
    }

    public Input SetPlaceholder(string placeholder)
    {
        this.Placeholder = placeholder;
        this.AddAttribute("placeholder", placeholder);
        return this;
    }

    public Input SetRequired()
    {
        this.IsRequired = true;
        this.AddAttribute("required");
        return this;
    }

    public Input SetDisabled()
    {
        this.IsDisabled = true;
        this.AddAttribute("disabled");
        return this;
    }

    public Input AddRegex(string regex)
    {
        this.AddAttribute("pattern", regex);
        return this;
    }
}
