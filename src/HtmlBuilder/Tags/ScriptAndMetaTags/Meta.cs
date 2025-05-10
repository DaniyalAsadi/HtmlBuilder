namespace HtmlBuilder.Tags.ScriptAndMetaTags;

public class Meta() : SingleTag("meta")
{
    public string MetaName { get; private set; } = string.Empty;
    public string Content { get; private set; } = string.Empty;
    public string HttpEquiv { get; private set; } = string.Empty;
    public string Charset { get; private set; } = string.Empty;


    public Meta SetName(string name)
    {
        this.MetaName = name;
        this.AddAttribute("name", name);
        return this;
    }
    public Meta SetContent(string content)
    {
        this.Content = content;
        this.AddAttribute("content", content);
        return this;
    }
    public Meta SetHttpEquiv(string httpEquiv)
    {
        this.HttpEquiv = httpEquiv;
        this.AddAttribute("http-equiv", httpEquiv);
        return this;
    }
    public Meta SetCharset(string charset)
    {
        this.Charset = charset;
        this.AddAttribute("charset", charset);
        return this;
    }
}
