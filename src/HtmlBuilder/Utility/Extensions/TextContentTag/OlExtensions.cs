using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class OlExtensions
{
    public static DoubleTagWithChildren Ol(this DoubleTagWithChildren doubleTag, Action<Ol> action)
    {
        Ol tag = new Ol();
        action(tag);
        return tag;
    }
}