namespace HtmlBuilder.Tags.StylingTags;
public class Small() : DoubleHtmlElementWithContent("small")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}