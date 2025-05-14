namespace HtmlBuilder.Tags.StylingTags;
public class Em() : DoubleHtmlElementWithContent("em")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}