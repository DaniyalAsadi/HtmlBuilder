namespace HtmlBuilder.Tags.TextContentTag;
public class Dt() : DoubleTagWithContent("dt")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}