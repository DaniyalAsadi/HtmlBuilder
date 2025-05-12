using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class DlExtensions
{
    public static DoubleTagWithChildren Dl(this DoubleTagWithChildren doubleTag, Action<Dl> action)
    {
        Dl tag = new Dl();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}