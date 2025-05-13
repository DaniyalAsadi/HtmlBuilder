namespace HtmlBuilder.Tags.StylingTags;
public class Span() : DoubleTagWithChildren("span")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}