namespace HtmlBuilder.Tags.TableTags;
public class Tbody() : DoubleTagWithChildren("tbody")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}