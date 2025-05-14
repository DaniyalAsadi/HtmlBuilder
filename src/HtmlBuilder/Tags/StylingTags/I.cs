namespace HtmlBuilder.Tags.StylingTags;
public class I() : DoubleHtmlElementWithContent("i")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}