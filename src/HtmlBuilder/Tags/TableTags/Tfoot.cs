namespace HtmlBuilder.Tags.TableTags;
public class Tfoot() : DoubleTagWithChildren("tfoot")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}