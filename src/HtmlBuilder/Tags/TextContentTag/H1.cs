namespace HtmlBuilder.Tags.TextContentTag;
public class H1() : DoubleTagWithContent("h1")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}