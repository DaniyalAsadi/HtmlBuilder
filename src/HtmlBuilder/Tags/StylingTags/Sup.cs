namespace HtmlBuilder.Tags.StylingTags;
public class Sup() : DoubleTagWithContent("sup")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}