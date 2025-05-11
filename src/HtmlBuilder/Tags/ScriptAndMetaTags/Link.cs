namespace HtmlBuilder.Tags.ScriptAndMetaTags;

public class Link() : SingleTag("link")
{
    public string Rel { get; private set; } = string.Empty;
    public string Type { get; private set; } = "text/css";
    public string Href { get; private set; } = string.Empty;
    public Link SetRel(string rel)
    {
        this.Rel = rel;
        this.AddAttribute("rel", rel);
        return this;
    }
    public Link SetType(string type)
    {
        this.Type = type;
        this.AddAttribute("type", type);
        return this;
    }
    public Link SetHref(string href)
    {
        this.Href = href;
        this.AddAttribute("href", href);
        return this;
    }
}
