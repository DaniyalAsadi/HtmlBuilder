namespace HtmlBuilder.Tags.StructuralTags;
public class Nav() : DoubleTagWithChildren("nav")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}