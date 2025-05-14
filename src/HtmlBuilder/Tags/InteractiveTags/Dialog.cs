namespace HtmlBuilder.Tags.InteractiveTags;
public class Dialog() : DoubleHtmlElementWithChildren("dialog")
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