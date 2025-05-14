namespace HtmlBuilder.Tags.FormTags;
public class Datalist() : DoubleHtmlElementWithChildren("datalist")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}