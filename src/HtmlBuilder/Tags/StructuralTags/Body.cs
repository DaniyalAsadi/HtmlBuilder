namespace HtmlBuilder.Tags.StructuralTags;
public class Body() : DoubleHtmlElementWithChildren("body")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}