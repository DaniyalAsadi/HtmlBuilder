namespace HtmlBuilder.Tags.TextContentTag;
public class P() : DoubleHtmlElementWithContent("p")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}