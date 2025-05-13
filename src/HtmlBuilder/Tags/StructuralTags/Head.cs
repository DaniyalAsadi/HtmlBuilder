namespace HtmlBuilder.Tags.StructuralTags;
public class Head() : DoubleTagWithChildren("head")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}