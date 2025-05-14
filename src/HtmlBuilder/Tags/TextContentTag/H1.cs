namespace HtmlBuilder.Tags.TextContentTag;
public class H1() : DoubleHtmlElementWithContent("h1")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}