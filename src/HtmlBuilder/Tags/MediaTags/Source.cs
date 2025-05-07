namespace HtmlBuilder.Tags.MediaTags;

public class Source() : SingleTag("source")
{
    public string Src { get; private set; } = string.Empty;
    public string Type { get; private set; } = string.Empty;

    public Source SetSrc(string src)
    {
        this.Src = src;
        this.AddAttribute("src", src);
        return this;
    }
    public Source SetType(string type)
    {
        this.Type = type;
        this.AddAttribute("type", type);
        return this;
    }
}
