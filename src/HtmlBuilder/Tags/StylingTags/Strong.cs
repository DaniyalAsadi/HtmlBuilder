namespace HtmlBuilder.Tags.StylingTags;
public class Strong() : DoubleHtmlElementWithContent("strong")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}