namespace HtmlBuilder.Tags.TextContentTag;
public class Hr() : SingleTag("hr")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}