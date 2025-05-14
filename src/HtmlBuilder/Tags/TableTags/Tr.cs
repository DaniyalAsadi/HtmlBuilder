namespace HtmlBuilder.Tags.TableTags;
public class Tr() : DoubleHtmlElementWithChildren("tr")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}