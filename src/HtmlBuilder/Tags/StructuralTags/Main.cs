namespace HtmlBuilder.Tags.StructuralTags;
public class Main() : DoubleTagWithChildren("main")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}