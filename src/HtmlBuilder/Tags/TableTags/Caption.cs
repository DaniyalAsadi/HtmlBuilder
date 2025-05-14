namespace HtmlBuilder.Tags.TableTags;
public class Caption() : DoubleHtmlElementWithContent("caption")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}