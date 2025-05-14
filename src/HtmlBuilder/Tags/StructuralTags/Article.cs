namespace HtmlBuilder.Tags.StructuralTags;
public class Article() : DoubleHtmlElementWithChildren("article")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}