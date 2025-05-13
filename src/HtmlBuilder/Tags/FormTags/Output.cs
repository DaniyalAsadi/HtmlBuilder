namespace HtmlBuilder.Tags.FormTags;
public class Output() : DoubleTagWithContent("output")
{
    public string OutputName { get; private set; } = string.Empty;
    public string For { get; private set; } = string.Empty;

    internal void SetName(string name)
    {
        this.OutputName = name;
        this.AddAttribute("name", name);
    }

    internal void SetForm(string @for)
    {
        this.For = @for;
        this.AddAttribute("form", @for);
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}