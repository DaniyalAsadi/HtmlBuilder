namespace HtmlBuilder.Tags.TextContentTag;
public class Ul() : DoubleTagWithChildren("ul")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}