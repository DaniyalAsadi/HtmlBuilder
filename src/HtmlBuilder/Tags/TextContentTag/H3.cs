namespace HtmlBuilder.Tags.TextContentTag;
public class H3() : DoubleHtmlElementWithContent("h3")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}