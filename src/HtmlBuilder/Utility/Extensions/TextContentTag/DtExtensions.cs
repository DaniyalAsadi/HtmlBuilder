using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class DtExtensions
{
    public static DoubleTagWithChildren Dt(this DoubleTagWithChildren doubleTag, Action<Dt> action)
    {
        Dt tag = new Dt();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}