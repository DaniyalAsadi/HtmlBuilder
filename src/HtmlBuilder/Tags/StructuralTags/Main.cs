namespace HtmlBuilder.Tags.StructuralTags;
public class Main() : DoubleHtmlElementWithChildren("main")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}