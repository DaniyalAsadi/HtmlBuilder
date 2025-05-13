namespace HtmlBuilder.Tags.TextContentTag;
public class Figure() : DoubleTagWithChildren("figure")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}