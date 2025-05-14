namespace HtmlBuilder.Tags.TextContentTag;
public class H6() : DoubleHtmlElementWithContent("h6")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}