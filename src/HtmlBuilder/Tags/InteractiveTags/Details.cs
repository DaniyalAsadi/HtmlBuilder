namespace HtmlBuilder.Tags.InteractiveTags;
public class Details() : DoubleHtmlElementWithChildren("details")
{
    public bool IsOpen { get; private set; } = false;

    internal void SetOpen()
    {
        IsOpen = true;
        AddAttribute("open");
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}