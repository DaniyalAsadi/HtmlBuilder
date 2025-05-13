namespace HtmlBuilder.Tags.StylingTags;
public class U() : DoubleTagWithContent("u")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}