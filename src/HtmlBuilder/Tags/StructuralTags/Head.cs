namespace HtmlBuilder.Tags.StructuralTags;
public class Head() : DoubleHtmlElementWithChildren("head")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}