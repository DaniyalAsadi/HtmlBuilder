using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.ScriptAndMetaTags;

public class Base() : SingleTag("base")
{
    public string Href { get; private set; } = string.Empty;
    public BaseTarget Target { get; private set; } = BaseTarget.Self;

    public Base SetHref(string href)
    {
        this.Href = href;
        this.AddAttribute("href", href);
        return this;
    }

    public Base SetTarget(BaseTarget target)
    {
        this.Target = target;
        this.AddAttribute("target", target.ToString().ToLower());
        return this;
    }
}
