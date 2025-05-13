namespace HtmlBuilder.Tags.TextContentTag;
public class H3() : DoubleTagWithContent("h3")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}