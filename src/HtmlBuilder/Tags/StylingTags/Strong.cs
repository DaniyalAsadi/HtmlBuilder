namespace HtmlBuilder.Tags.StylingTags;
public class Strong() : DoubleTagWithContent("strong")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}