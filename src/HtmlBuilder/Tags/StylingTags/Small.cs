namespace HtmlBuilder.Tags.StylingTags;
public class Small() : DoubleTagWithContent("small")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}