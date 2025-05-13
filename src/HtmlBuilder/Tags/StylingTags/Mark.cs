namespace HtmlBuilder.Tags.StylingTags;
public class Mark() : DoubleTagWithContent("mark")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}