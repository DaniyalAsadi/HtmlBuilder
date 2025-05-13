namespace HtmlBuilder.Tags.FormTags;
public class Legend() : DoubleTagWithContent("legend")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}