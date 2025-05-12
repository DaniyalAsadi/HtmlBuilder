using System;

namespace HtmlBuilder.Tags.TableTags;
public static class CaptionExtensions
{
    public static DoubleTagWithChildren Caption(this DoubleTagWithChildren doubleTag, Action<Caption> action)
    {
        Caption tag = new Caption();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}