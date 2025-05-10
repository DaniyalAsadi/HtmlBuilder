namespace HtmlBuilder.Tags.ScriptAndMetaTags;

public class Style() : DoubleTagWithContent("style")
{
    public string Type { get; private set; } = "text/css";
    public string Media { get; private set; } = string.Empty;

    public Style SetType(string type)
    {
        this.Type = type;
        this.AddAttribute("type", type);
        return this;
    }

    public Style SetMedia(string media)
    {
        this.Media = media;
        this.AddAttribute("media", media);
        return this;
    }
}
