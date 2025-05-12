using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class DtExtensions
{
    public static Dt Dt(this DoubleTagWithChildren doubleTag, Action<Dt> action)
    {
        Dt tag = new Dt();
        action(tag);
        return tag;
    }
}