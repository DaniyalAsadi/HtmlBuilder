namespace HtmlBuilder.Tags.TextContentTag;
public class Ul() : DoubleHtmlElementWithChildren("ul")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}