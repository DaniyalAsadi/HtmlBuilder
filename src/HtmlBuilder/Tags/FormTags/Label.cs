namespace HtmlBuilder.Tags.FormTags;
public class Label() : DoubleTagWithContent("label")
{
    public string For { get; private set; } = string.Empty;

    internal void SetFor(string @for)
    {
        this.For = @for;
        this.AddAttribute("For", @for);
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}