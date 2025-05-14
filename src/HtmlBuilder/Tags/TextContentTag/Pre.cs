namespace HtmlBuilder.Tags.TextContentTag;
public class Pre() : DoubleHtmlElementWithContent("pre")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}