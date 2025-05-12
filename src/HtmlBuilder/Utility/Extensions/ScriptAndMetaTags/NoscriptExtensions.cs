using System;

namespace HtmlBuilder.Tags.ScriptAndMetaTags;
public static class NoscriptExtensions
{
    public static Noscript Noscript(this DoubleTagWithChildren doubleTag, Action<Noscript> action)
    {
        Noscript tag = new Noscript();
        action(tag);
        return tag;
    }
}