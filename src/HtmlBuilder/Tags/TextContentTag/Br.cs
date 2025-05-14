namespace HtmlBuilder.Tags.TextContentTag;
public class Br() : SingleHtmlElement("br")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}