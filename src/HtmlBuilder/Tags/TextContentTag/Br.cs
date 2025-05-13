namespace HtmlBuilder.Tags.TextContentTag;
public class Br() : SingleTag("br")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}