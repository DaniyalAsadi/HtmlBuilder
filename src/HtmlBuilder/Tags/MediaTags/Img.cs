namespace HtmlBuilder.Tags.MediaTags;
public class Img() : SingleTag("img")
{
    public string Src { get; private set; } = string.Empty;
    public string Alt { get; private set; } = string.Empty;
    public string Width { get; private set; }
    public string Height { get; private set; }

    internal void SetSrc(string src)
    {
        this.Src = src;
        this.AddAttribute("src", src);
    }

    internal void SetAlt(string alt)
    {
        this.Alt = alt;
        this.AddAttribute("alt", alt);
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
}