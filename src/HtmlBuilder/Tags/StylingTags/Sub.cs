namespace HtmlBuilder.Tags.StylingTags;
public class Sub() : DoubleHtmlElementWithContent("sub")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}