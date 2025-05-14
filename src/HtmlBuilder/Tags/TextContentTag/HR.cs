namespace HtmlBuilder.Tags.TextContentTag;
public class Hr() : SingleHtmlElement("hr")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}