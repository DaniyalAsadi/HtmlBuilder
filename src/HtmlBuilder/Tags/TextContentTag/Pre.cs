namespace HtmlBuilder.Tags.TextContentTag;
public class Pre() : DoubleTagWithContent("pre")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}