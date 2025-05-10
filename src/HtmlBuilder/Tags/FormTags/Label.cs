namespace HtmlBuilder.Tags.FormTags;

public class Label() : DoubleTagWithContent("label")
{
    public string For { get; private set; } = string.Empty;

    public Label SetFor(string @for)
    {
        this.For = @for;
        this.AddAttribute("For", @for);
        return this;
    }
}
