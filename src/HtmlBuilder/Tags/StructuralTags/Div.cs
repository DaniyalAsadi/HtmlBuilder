namespace HtmlBuilder.Tags.StructuralTags;
public class Div() : DoubleHtmlElementWithChildren("div")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}