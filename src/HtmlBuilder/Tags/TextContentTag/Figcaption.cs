namespace HtmlBuilder.Tags.TextContentTag;
public class Figcaption() : DoubleTagWithContent("figcaption")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}