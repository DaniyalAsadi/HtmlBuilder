namespace HtmlBuilder.Tags.MediaTags;
public class Audio() : DoubleTagWithChildren("audio")
{
    public string Src { get; private set; } = string.Empty;
    public bool Controls { get; private set; } = false;
    public bool Autoplay { get; private set; } = false;
    public bool Loop { get; private set; } = false;
    public bool Muted { get; private set; } = false;

    internal void SetSrc(string src)
    {
        this.Src = src;
        this.AddAttribute("src", src);
    }

    internal void SetControls()
    {
        this.Controls = true;
        this.AddAttribute("controls");
    }

    internal void SetAutoplay()
    {
        this.Autoplay = true;
        this.AddAttribute("autoplay");
    }

    internal void SetLoop()
    {
        this.Loop = true;
        this.AddAttribute("loop");
    }

    internal void SetMuted()
    {
        this.Muted = true;
        this.AddAttribute("muted");
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}