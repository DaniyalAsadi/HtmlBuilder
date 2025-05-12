using System;

namespace HtmlBuilder.Tags.ScriptAndMetaTags;
public static class MetaExtensions
{
    public static SingleTag Meta(this DoubleTagWithChildren doubleTag, Action<Meta> action)
    {
        Meta tag = new Meta();
        action(tag);
        return tag;
    }
}