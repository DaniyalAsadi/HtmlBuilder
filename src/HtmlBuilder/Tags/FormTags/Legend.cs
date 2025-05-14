namespace HtmlBuilder.Tags.FormTags;
public class Legend() : DoubleHtmlElementWithContent("legend")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}
