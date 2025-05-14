namespace HtmlBuilder.Tags.StructuralTags;
public class Header() : DoubleHtmlElementWithChildren("header")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}