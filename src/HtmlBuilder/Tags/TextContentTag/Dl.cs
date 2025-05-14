namespace HtmlBuilder.Tags.TextContentTag;
public class Dl() : DoubleHtmlElementWithChildren("dl")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}