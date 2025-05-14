namespace HtmlBuilder.Tags.TableTags;
public class Tfoot() : DoubleHtmlElementWithChildren("tfoot")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}