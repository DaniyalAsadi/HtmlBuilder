namespace HtmlBuilder.Tags.StructuralTags;
public class Html() : DoubleHtmlElementWithChildren("html")
{
    public string Lang { get; private set; } = string.Empty;
    public string Manifest { get; private set; } = string.Empty;

    internal void SetLang(string lang)
    {
        this.Lang = lang;
        this.AddAttribute("lang", lang);
    }

    internal void SetManifest(string manifestUrl)
    {
        this.Manifest = manifestUrl;
        this.AddAttribute("manifest", manifestUrl);
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}