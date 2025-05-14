namespace HtmlBuilder.Tags.ScriptAndMetaTags;
public class Style() : DoubleHtmlElementWithContent("style")
{
    public string Type { get; private set; } = "text/css";
    public string Media { get; private set; } = string.Empty;

    internal void SetType(string type)
    {
        this.Type = type;
        this.AddAttribute("type", type);
    }

    internal void SetMedia(string media)
    {
        this.Media = media;
        this.AddAttribute("media", media);
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}