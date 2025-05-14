namespace HtmlBuilder.Tags.StylingTags;
public class U() : DoubleHtmlElementWithContent("u")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}