using System;

namespace HtmlBuilder.Tags.TableTags;
public static class TheadExtensions
{
    public static Thead Thead(this DoubleTagWithChildren doubleTag, Action<Thead> action)
    {
        Thead tag = new Thead();
        action(tag);
        return tag;
    }
}