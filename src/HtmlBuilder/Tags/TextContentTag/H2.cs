namespace HtmlBuilder.Tags.TextContentTag;
public class H2() : DoubleHtmlElementWithContent("h2")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}