namespace HtmlBuilder.Tags.StructuralTags;
public class Nav() : DoubleHtmlElementWithChildren("nav")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}