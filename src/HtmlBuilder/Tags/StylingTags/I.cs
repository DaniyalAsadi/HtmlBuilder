namespace HtmlBuilder.Tags.StylingTags;
public class I() : DoubleTagWithContent("i")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}