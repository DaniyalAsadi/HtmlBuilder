namespace HtmlBuilder.Tags.MediaTags;

public class Iframe() : SingleTag("iframe")
{
    public string Src { get; private set; } = string.Empty;
    public string Width { get; private set; }
    public string Height { get; private set; }
    public string Frameborder { get; private set; }
    public bool AllowFullscreen { get; private set; } = false;

    public Iframe SetSrc(string src)
    {
        Src = src;
        AddAttribute("src", src);
        return this;
    }

    public Iframe SetWidth(string width)
    {
        Width = width;
        AddAttribute("width", width);
        return this;
    }

    public Iframe SetHeight(string height)
    {
        Height = height;
        AddAttribute("height", height);
        return this;
    }

    public Iframe SetFrameborder(string frameborder)
    {
        Frameborder = frameborder;
        AddAttribute("frameborder", frameborder);
        return this;
    }

    public Iframe SetAllowFullscreen()
    {
        AllowFullscreen = true;
        AddAttribute("allowfullscreen");
        return this;
    }
}

