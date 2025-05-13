namespace HtmlBuilder.Tags.TableTags;
public class Thead() : DoubleTagWithChildren("thead")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}