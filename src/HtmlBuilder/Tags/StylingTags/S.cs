namespace HtmlBuilder.Tags.StylingTags;
public class S() : DoubleTagWithContent("s")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}