using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.InteractiveTags;
public class A() : DoubleTagWithContent("a")
{
    public string Href { get; private set; } = string.Empty;
    public string Rel { get; private set; } = string.Empty;
    public string Type { get; private set; } = string.Empty;
    public ATarget Target { get; private set; } = ATarget.Self;

    internal void SetHref(string href)
    {
        this.Href = href;
        this.AddAttribute("href", href);
    }

    internal void SetRel(string rel)
    {
        this.Rel = rel;
        this.AddAttribute("rel", rel);
    }

    internal void SetType(string type)
    {
        this.Type = type;
        this.AddAttribute("type", type);
    }

    internal void SetTarget(ATarget target)
    {
        this.Target = target;
        this.AddAttribute("target", target.ToHtmlString());
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}