namespace HtmlBuilder.Tags.MediaTags;
public class Source() : SingleTag("source")
{
    public string Src { get; private set; } = string.Empty;
    public string Type { get; private set; } = string.Empty;

    internal void SetSrc(string src)
    {
        this.Src = src;
        this.AddAttribute("src", src);
    }

    internal void SetType(string type)
    {
        this.Type = type;
        this.AddAttribute("type", type);
    }
}