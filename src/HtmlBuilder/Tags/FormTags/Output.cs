namespace HtmlBuilder.Tags.FormTags;

public class Output() : DoubleTagWithContent("output")
{
    public string OutputName { get; private set; } = string.Empty;
    public string For { get; private set; } = string.Empty;
    public Output SetName(string name)
    {
        this.OutputName = name;
        this.AddAttribute("name", name);
        return this;
    }

    public Output SetForm(string @for)
    {
        this.For = @for;
        this.AddAttribute("form", @for);
        return this;
    }
}
