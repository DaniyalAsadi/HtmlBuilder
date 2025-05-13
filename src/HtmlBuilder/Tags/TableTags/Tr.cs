namespace HtmlBuilder.Tags.TableTags;
public class Tr() : DoubleTagWithChildren("tr")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}