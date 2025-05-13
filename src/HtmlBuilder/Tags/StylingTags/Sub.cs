namespace HtmlBuilder.Tags.StylingTags;
public class Sub() : DoubleTagWithContent("sub")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}