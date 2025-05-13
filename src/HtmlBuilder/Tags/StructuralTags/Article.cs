namespace HtmlBuilder.Tags.StructuralTags;
public class Article() : DoubleTagWithChildren("article")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}