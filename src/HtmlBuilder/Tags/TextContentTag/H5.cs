namespace HtmlBuilder.Tags.TextContentTag;
public class H5() : DoubleHtmlElementWithContent("h5")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}