namespace HtmlBuilder.Tags.StylingTags;
public class Span() : DoubleHtmlElementWithChildren("span")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}