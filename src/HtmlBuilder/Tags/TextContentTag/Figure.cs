namespace HtmlBuilder.Tags.TextContentTag;
public class Figure() : DoubleHtmlElementWithChildren("figure")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}