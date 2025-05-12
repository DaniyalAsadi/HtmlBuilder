using System;

namespace HtmlBuilder.Tags.ScriptAndMetaTags;
public static class StyleExtensions
{
    public static DoubleTagWithContent Style(this DoubleTagWithChildren doubleTag, Action<Style> action)
    {
        Style tag = new Style();
        action(tag);
        return tag;
    }
}