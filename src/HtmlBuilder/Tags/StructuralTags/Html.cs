namespace HtmlBuilder.Tags.StructuralTags;
public class Html() : DoubleTagWithChildren("html")
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
}