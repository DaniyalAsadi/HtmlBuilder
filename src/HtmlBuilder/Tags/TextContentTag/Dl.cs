namespace HtmlBuilder.Tags.TextContentTag;
public class Dl() : DoubleTagWithChildren("dl")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}