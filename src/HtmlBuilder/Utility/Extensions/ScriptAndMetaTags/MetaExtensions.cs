using System;

namespace HtmlBuilder.Tags.ScriptAndMetaTags;
public static class MetaExtensions
{
    public static Meta Meta(this DoubleTagWithChildren doubleTag, Action<Meta> action)
    {
        Meta tag = new Meta();
        action(tag);
        return tag;
    }

    public static Meta SetName(this Meta tag, string name)
    {
        tag.SetName(name);
        return tag;
    }

    public static Meta SetContent(this Meta tag, string content)
    {
        tag.SetContent(content);
        return tag;
    }

    public static Meta SetHttpEquiv(this Meta tag, string httpEquiv)
    {
        tag.SetHttpEquiv(httpEquiv);
        return tag;
    }

    public static Meta SetCharset(this Meta tag, string charset)
    {
        tag.SetCharset(charset);
        return tag;
    }
}