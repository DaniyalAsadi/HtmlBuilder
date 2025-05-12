namespace HtmlBuilder.Tags.TextContentTag;
public class Ol() : DoubleTagWithChildren("ol")
{
    public string Type { get; private set; } = string.Empty;
    public int Start { get; private set; } = 1;
    public bool Reversed { get; private set; } = false;

    internal void SetType(string type)
    {
        this.Type = type;
        this.AddAttribute("type", type);
    }

    internal void SetStart(int start)
    {
        this.Start = start;
        this.AddAttribute("start", start.ToString());
    }

    internal void SetReversed()
    {
        this.Reversed = true;
        this.AddAttribute("reversed");
    }
}