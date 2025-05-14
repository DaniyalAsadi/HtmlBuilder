namespace HtmlBuilder.Tags.TextContentTag;
public class Figcaption() : DoubleHtmlElementWithContent("figcaption")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}