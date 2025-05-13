namespace HtmlBuilder.Tags.StylingTags;
public class B() : DoubleTagWithContent("b")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}