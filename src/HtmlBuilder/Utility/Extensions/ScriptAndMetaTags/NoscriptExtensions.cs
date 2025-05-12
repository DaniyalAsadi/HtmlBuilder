using System;

namespace HtmlBuilder.Tags.ScriptAndMetaTags;
public static class NoscriptExtensions
{
    public static DoubleTagWithChildren Noscript(this DoubleTagWithChildren doubleTag, Action<Noscript> action)
    {
        Noscript tag = new Noscript();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}