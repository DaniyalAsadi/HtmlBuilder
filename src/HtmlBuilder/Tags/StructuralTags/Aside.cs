namespace HtmlBuilder.Tags.StructuralTags;
public class Aside() : DoubleHtmlElementWithChildren("aside")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}