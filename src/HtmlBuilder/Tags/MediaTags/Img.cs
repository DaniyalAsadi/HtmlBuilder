namespace HtmlBuilder.Tags.MediaTags;

public class Img() : SingleTag("img")
{
    public string Src { get; private set; } = string.Empty;
    public string Alt { get; private set; } = string.Empty;
    public string Width { get; private set; }
    public string Height { get; private set; }

    public Img SetSrc(string src)
    {
        this.Src = src;
        this.AddAttribute("src", src);
        return this;
    }

    public Img SetAlt(string alt)
    {
        this.Alt = alt;
        this.AddAttribute("alt", alt);
        return this;
    }

    public Img SetWidth(string width)
    {
        this.Width = width;
        this.AddAttribute("width", width);
        return this;
    }

    public Img SetHeight(string height)
    {
        this.Height = height;
        this.AddAttribute("height", height);
        return this;
    }

}
