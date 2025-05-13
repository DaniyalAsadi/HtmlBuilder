namespace HtmlBuilder.Tags.MediaTags;
public class Video() : DoubleTagWithChildren("video")
{
    public string Src { get; private set; } = string.Empty;
    public bool Controls { get; private set; } = false;
    public bool Autoplay { get; private set; } = false;
    public bool Loop { get; private set; } = false;
    public bool Muted { get; private set; } = false;
    public string Width { get; private set; }
    public string Height { get; private set; }

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

    internal void SetWidth(string width)
    {
        this.Width = width;
        this.AddAttribute("width", width);
    }

    internal void SetHeight(string height)
    {
        this.Height = height;
        this.AddAttribute("height", height);
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}