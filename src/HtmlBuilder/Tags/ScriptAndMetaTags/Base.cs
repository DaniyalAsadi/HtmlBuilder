using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.ScriptAndMetaTags;
public class Base() : SingleTag("base")
{
    public string Href { get; private set; } = string.Empty;
    public BaseTarget Target { get; private set; } = BaseTarget.Self;

    internal void SetHref(string href)
    {
        this.Href = href;
        this.AddAttribute("href", href);
    }

    internal void SetTarget(BaseTarget target)
    {
        this.Target = target;
        this.AddAttribute("target", target.ToHtmlString());
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}