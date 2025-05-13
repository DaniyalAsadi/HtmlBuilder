namespace HtmlBuilder.Tags.TableTags;
public class Caption() : DoubleTagWithContent("caption")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}