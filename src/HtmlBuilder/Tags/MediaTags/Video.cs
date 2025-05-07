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

    public Video SetSrc(string src)
    {
        this.Src = src;
        this.AddAttribute("src", src);
        return this;
    }

    public Video SetControls()
    {
        this.Controls = true;
        this.AddAttribute("controls");
        return this;
    }

    public Video SetAutoplay()
    {
        this.Autoplay = true;
        this.AddAttribute("autoplay");
        return this;
    }

    public Video SetLoop()
    {
        this.Loop = true;
        this.AddAttribute("loop");
        return this;
    }

    public Video SetMuted()
    {
        this.Muted = true;
        this.AddAttribute("muted");
        return this;
    }

    public Video SetWidth(string width)
    {
        this.Width = width;
        this.AddAttribute("width", width);
        return this;
    }

    public Video SetHeight(string height)
    {
        this.Height = height;
        this.AddAttribute("height", height);
        return this;
    }


}
