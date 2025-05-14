namespace HtmlBuilder.Tags.MediaTags;
public class Iframe() : SingleHtmlElement("iframe")
{
    public string Src { get; private set; } = string.Empty;
    public string Width { get; private set; }
    public string Height { get; private set; }
    public string Frameborder { get; private set; }
    public bool AllowFullscreen { get; private set; } = false;

    internal void SetSrc(string src)
    {
        Src = src;
        AddAttribute("src", src);
    }

    internal void SetWidth(string width)
    {
        Width = width;
        AddAttribute("width", width);
    }

    internal void SetHeight(string height)
    {
        Height = height;
        AddAttribute("height", height);
    }

    internal void SetFrameborder(string frameborder)
    {
        Frameborder = frameborder;
        AddAttribute("frameborder", frameborder);
    }

    internal void SetAllowFullscreen()
    {
        AllowFullscreen = true;
        AddAttribute("allowfullscreen");
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}