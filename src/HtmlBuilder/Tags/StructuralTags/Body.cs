namespace HtmlBuilder.Tags.StructuralTags;
public class Body() : DoubleTagWithChildren("body")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}