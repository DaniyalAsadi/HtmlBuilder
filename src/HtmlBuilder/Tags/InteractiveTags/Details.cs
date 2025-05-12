namespace HtmlBuilder.Tags.InteractiveTags;
public class Details() : DoubleTagWithChildren("details")
{
    public bool IsOpen { get; private set; } = false;

    internal void SetOpen()
    {
        IsOpen = true;
        AddAttribute("open");
    }
}