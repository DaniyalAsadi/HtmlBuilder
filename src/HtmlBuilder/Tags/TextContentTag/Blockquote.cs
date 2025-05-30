namespace HtmlBuilder.Tags.TextContentTag;
public class Blockquote() : DoubleHtmlElementWithContent("blockquote")
{
    public string Cite { get; private set; } = string.Empty;

    internal void SetCite(string cite)
    {
        this.Cite = cite;
        this.AddAttribute("cite", cite);
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}