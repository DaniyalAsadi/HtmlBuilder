namespace HtmlBuilder.Tags.InteractiveTags;
public class Dialog() : DoubleTagWithChildren("dialog")
{
    public bool IsOpen { get; private set; } = false;

    internal void SetOpen()
    {
        IsOpen = true;
        AddAttribute("open");
    }
}