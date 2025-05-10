namespace HtmlBuilder.Tags.InteractiveTags;

public class Details() : DoubleTagWithChildren("details")
{
    public bool IsOpen { get; private set; } = false;

    public Details SetOpen()
    {
        IsOpen = true;
        AddAttribute("open");
        return this;
    }
}
