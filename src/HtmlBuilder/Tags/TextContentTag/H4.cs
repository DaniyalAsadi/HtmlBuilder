namespace HtmlBuilder.Tags.TextContentTag;
public class H4() : DoubleHtmlElementWithContent("h4")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}