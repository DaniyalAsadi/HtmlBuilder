namespace HtmlBuilder.Tags.StructuralTags;
public class Header() : DoubleTagWithChildren("header")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}