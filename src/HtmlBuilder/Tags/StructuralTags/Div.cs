namespace HtmlBuilder.Tags.StructuralTags;
public class Div() : DoubleTagWithChildren("div")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}