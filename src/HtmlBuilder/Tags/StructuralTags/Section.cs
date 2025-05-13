namespace HtmlBuilder.Tags.StructuralTags;
public class Section() : DoubleTagWithChildren("section")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}