using System;

namespace HtmlBuilder.Tags.TableTags;
public static class ColgroupExtensions
{
    public static Colgroup Colgroup(this DoubleTagWithChildren doubleTag, Action<Colgroup> action)
    {
        Colgroup tag = new Colgroup();
        action(tag);
        return tag;
    }

    public static Colgroup SetSpan(this Colgroup tag, int span)
    {
        tag.SetSpan(span);
        return tag;
    }
}