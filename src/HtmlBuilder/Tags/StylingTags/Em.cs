namespace HtmlBuilder.Tags.StylingTags;
public class Em() : DoubleTagWithContent("em")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}