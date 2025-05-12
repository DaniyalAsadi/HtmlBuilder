using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class MainExtensions
{
    public static DoubleTagWithChildren Main(this DoubleTagWithChildren doubleTag, Action<Main> action)
    {
        Main tag = new Main();
        action(tag);
        return tag;
    }
}