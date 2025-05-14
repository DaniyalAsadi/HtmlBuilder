namespace HtmlBuilder.Tags.StylingTags;
public class Sup() : DoubleHtmlElementWithContent("sup")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}