namespace HtmlBuilder.Tags.TextContentTag;
public class P() : DoubleTagWithContent("p")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}