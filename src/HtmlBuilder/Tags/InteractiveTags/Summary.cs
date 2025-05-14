namespace HtmlBuilder.Tags.InteractiveTags;
public class Summary() : DoubleHtmlElementWithContent("summary")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}