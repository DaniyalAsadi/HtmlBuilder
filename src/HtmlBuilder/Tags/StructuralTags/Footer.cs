namespace HtmlBuilder.Tags.StructuralTags;
public class Footer() : DoubleHtmlElementWithChildren("footer")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}