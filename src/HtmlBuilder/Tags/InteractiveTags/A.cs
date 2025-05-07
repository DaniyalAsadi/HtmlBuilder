namespace HtmlBuilder.Tags.InteractiveTags;

public class A() : DoubleTagWithContent("a")
{
    public string Href { get; private set; } = string.Empty;
    public string Rel { get; private set; } = string.Empty;
    public string Type { get; private set; } = string.Empty;
    public string Target { get; private set; } = string.Empty;


    public A SetHref(string href)
    {
        this.Href = href;
        this.AddAttribute("href", href);
        return this;
    }

    public A SetRel(string rel)
    {
        this.Rel = rel;
        this.AddAttribute("rel", rel);
        return this;
    }

    public A SetType(string type)
    {
        this.Type = type;
        this.AddAttribute("type", type);
        return this;
    }

    public A SetTarget(string target)
    {
        this.Target = target;
        this.AddAttribute("target", target);
        return this;
    }

}
