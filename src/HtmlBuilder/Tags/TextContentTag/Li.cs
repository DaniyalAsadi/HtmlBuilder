namespace HtmlBuilder.Tags.TextContentTag;
public class Li() : DoubleHtmlElementWithContent("li")
{
    public string Value { get; private set; } = string.Empty;

    internal void SetValue(string value)
    {
        this.Value = value;
        this.AddAttribute("value", value);
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}