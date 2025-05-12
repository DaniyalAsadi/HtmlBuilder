using System;

namespace HtmlBuilder.Tags.TableTags;
public static class TheadExtensions
{
    public static DoubleTagWithChildren Thead(this DoubleTagWithChildren doubleTag, Action<Thead> action)
    {
        Thead tag = new Thead();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}