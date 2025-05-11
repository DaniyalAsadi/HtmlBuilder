using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.MediaTags;

public class Track() : SingleTag("track")
{
    public string Src { get; private set; } = string.Empty;
    public TrackKind Kind { get; private set; } = TrackKind.Subtitles;
    public string Srclang { get; private set; } = string.Empty;
    public string Label { get; private set; } = string.Empty;
    public bool IsDefault { get; private set; } = false;

    public Track SetSrc(string src)
    {
        Src = src;
        AddAttribute("src", src);
        return this;
    }

    public Track SetKind(TrackKind kind)
    {
        Kind = kind;
        AddAttribute("kind", kind.ToString().ToLower());
        return this;
    }

    public Track SetSrclang(string srclang)
    {
        Srclang = srclang;
        AddAttribute("srclang", srclang);
        return this;
    }

    public Track SetLabel(string label)
    {
        Label = label;
        AddAttribute("label", label);
        return this;
    }

    public Track SetDefault()
    {
        IsDefault = true;
        AddAttribute("default");
        return this;
    }
}
