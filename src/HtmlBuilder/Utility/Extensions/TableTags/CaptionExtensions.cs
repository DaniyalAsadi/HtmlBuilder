using System;

namespace HtmlBuilder.Tags.TableTags;
public static class CaptionExtensions
{
    public static DoubleTagWithContent Caption(this DoubleTagWithChildren doubleTag, Action<Caption> action)
    {
        Caption tag = new Caption();
        action(tag);
        return tag;
    }
}