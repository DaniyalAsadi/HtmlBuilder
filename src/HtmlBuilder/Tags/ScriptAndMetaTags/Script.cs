namespace HtmlBuilder.Tags.ScriptAndMetaTags;
public class Script() : DoubleHtmlElementWithContent("script")
{
    public string Src { get; private set; } = string.Empty;
    public string type { get; private set; } = "text/javascript";
    public bool IsAsync { get; private set; } = false;
    public bool IsDefer { get; private set; } = false;

    internal void SetSrc(string src)
    {
        this.Src = src;
        this.AddAttribute("src", src);
    }

    internal void SetType(string type)
    {
        this.type = type;
        this.AddAttribute("type", type);
    }

    internal void SetAsync()
    {
        this.IsAsync = true;
        this.AddAttribute("async");
    }

    internal void SetDefer()
    {
        this.IsDefer = true;
        this.AddAttribute("defer");
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}