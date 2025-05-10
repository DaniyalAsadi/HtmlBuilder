namespace HtmlBuilder.Tags.ScriptAndMetaTags;

public class Script() : DoubleTagWithContent("script")
{
    public string Src { get; private set; } = string.Empty;
    public string type { get; private set; } = "text/javascript";
    public bool IsAsync { get; private set; } = false;
    public bool IsDefer { get; private set; } = false;

    public Script SetSrc(string src)
    {
        this.Src = src;
        this.AddAttribute("src", src);
        return this;
    }

    public Script SetType(string type)
    {
        this.type = type;
        this.AddAttribute("type", type);
        return this;
    }

    public Script SetAsync()
    {
        this.IsAsync = true;
        this.AddAttribute("async");
        return this;
    }

    public Script SetDefer()
    {
        this.IsDefer = true;
        this.AddAttribute("defer");
        return this;
    }

}
