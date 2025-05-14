namespace HtmlBuilder.Tags.TextContentTag;
public class Dd() : DoubleHtmlElementWithContent("dd")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}