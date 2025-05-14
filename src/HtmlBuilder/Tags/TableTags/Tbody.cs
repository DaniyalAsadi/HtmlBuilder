namespace HtmlBuilder.Tags.TableTags;
public class Tbody() : DoubleHtmlElementWithChildren("tbody")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}