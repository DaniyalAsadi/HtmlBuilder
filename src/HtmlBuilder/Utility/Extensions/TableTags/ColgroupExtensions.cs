using System;

namespace HtmlBuilder.Tags.TableTags;
public static class ColgroupExtensions
{
    public static DoubleTagWithChildren Colgroup(this DoubleTagWithChildren doubleTag, Action<Colgroup> action)
    {
        Colgroup tag = new Colgroup();
        action(tag);
        return tag;
    }
}