namespace HtmlBuilder.Tags.StructuralTags;
public class Section() : DoubleHtmlElementWithChildren("section")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}