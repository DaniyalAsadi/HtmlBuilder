using System;

namespace HtmlBuilder.Tags.InteractiveTags;
public static class AExtensions
{
    public static DoubleTagWithContent A(this DoubleTagWithChildren doubleTag, Action<A> action)
    {
        A tag = new A();
        action(tag);
        return tag;
    }
}