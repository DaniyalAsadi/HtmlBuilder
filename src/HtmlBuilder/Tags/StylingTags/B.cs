namespace HtmlBuilder.Tags.StylingTags;
public class B() : DoubleHtmlElementWithContent("b")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}