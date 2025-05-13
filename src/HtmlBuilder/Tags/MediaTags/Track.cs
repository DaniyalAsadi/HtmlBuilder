using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.MediaTags;
public class Track() : SingleTag("track")
{
    public string Src { get; private set; } = string.Empty;
    public TrackKind Kind { get; private set; } = TrackKind.Subtitles;
    public string Srclang { get; private set; } = string.Empty;
    public string Label { get; private set; } = string.Empty;
    public bool IsDefault { get; private set; } = false;

    internal void SetSrc(string src)
    {
        Src = src;
        AddAttribute("src", src);
    }

    internal void SetKind(TrackKind kind)
    {
        Kind = kind;
        AddAttribute("kind", kind.ToHtmlString());
    }

    internal void SetSrclang(string srclang)
    {
        Srclang = srclang;
        AddAttribute("srclang", srclang);
    }

    internal void SetLabel(string label)
    {
        Label = label;
        AddAttribute("label", label);
    }

    internal void SetDefault()
    {
        IsDefault = true;
        AddAttribute("default");
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}