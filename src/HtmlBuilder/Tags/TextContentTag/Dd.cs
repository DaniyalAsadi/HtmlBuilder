namespace HtmlBuilder.Tags.TextContentTag;
public class Dd() : DoubleTagWithContent("dd")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}