namespace HtmlBuilder.Tags.FormTags;
public class Datalist() : DoubleTagWithChildren("datalist")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}