namespace HtmlBuilder.Tags.MediaTags;

public class Audio() : DoubleTagWithChildren("audio")
{
    public string Src { get; private set; } = string.Empty;
    public bool Controls { get; private set; } = false;
    public bool Autoplay { get; private set; } = false;
    public bool Loop { get; private set; } = false;
    public bool Muted { get; private set; } = false;

    public Audio SetSrc(string src)
    {
        this.Src = src;
        this.AddAttribute("src", src);
        return this;
    }

    public Audio SetControls()
    {
        this.Controls = true;
        this.AddAttribute("controls");
        return this;
    }

    public Audio SetAutoplay()
    {
        this.Autoplay = true;
        this.AddAttribute("autoplay");
        return this;
    }

    public Audio SetLoop()
    {
        this.Loop = true;
        this.AddAttribute("loop");
        return this;
    }

    public Audio SetMuted()
    {
        this.Muted = true;
        this.AddAttribute("muted");
        return this;
    }
}
