namespace HtmlBuilder.Tags.InteractiveTags;
public class Summary() : DoubleTagWithContent("summary")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}