namespace HtmlBuilder.Tags.ScriptAndMetaTags;
public class Meta() : SingleHtmlElement("meta")
{
    public string MetaName { get; private set; } = string.Empty;
    public string Content { get; private set; } = string.Empty;
    public string HttpEquiv { get; private set; } = string.Empty;
    public string Charset { get; private set; } = string.Empty;

    internal void SetName(string name)
    {
        this.MetaName = name;
        this.AddAttribute("name", name);
    }

    internal void SetContent(string content)
    {
        this.Content = content;
        this.AddAttribute("content", content);
    }

    internal void SetHttpEquiv(string httpEquiv)
    {
        this.HttpEquiv = httpEquiv;
        this.AddAttribute("http-equiv", httpEquiv);
    }

    internal void SetCharset(string charset)
    {
        this.Charset = charset;
        this.AddAttribute("charset", charset);
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}