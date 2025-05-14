namespace HtmlBuilder.Tags.StylingTags;
public class S() : DoubleHtmlElementWithContent("s")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}