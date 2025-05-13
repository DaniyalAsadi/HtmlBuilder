namespace HtmlBuilder.Tags.StructuralTags;
public class Footer() : DoubleTagWithChildren("footer")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}