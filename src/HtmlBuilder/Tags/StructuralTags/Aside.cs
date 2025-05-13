namespace HtmlBuilder.Tags.StructuralTags;
public class Aside() : DoubleTagWithChildren("aside")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}