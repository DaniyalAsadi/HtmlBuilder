namespace HtmlBuilder.Tags.TextContentTag;
public class Dt() : DoubleHtmlElementWithContent("dt")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}