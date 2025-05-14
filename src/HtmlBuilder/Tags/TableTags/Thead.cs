namespace HtmlBuilder.Tags.TableTags;
public class Thead() : DoubleHtmlElementWithChildren("thead")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}