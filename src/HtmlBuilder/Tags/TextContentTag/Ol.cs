using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.TextContentTag;
public class Ol() : DoubleHtmlElementWithChildren("ol")
{
    public OlType Type { get; private set; }
    public int Start { get; private set; } = 1;
    public bool Reversed { get; private set; } = false;

    internal void SetType(OlType type)
    {
        this.Type = type;
        this.AddAttribute("type", type.ToHtmlString());
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

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}