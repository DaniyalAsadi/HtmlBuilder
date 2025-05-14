namespace HtmlBuilder.Tags.StylingTags;
public class Mark() : DoubleHtmlElementWithContent("mark")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}