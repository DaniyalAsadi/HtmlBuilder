using System;

namespace HtmlBuilder.Tags.TableTags;
public static class TbodyExtensions
{
    public static Tbody Tbody(this DoubleTagWithChildren doubleTag, Action<Tbody> action)
    {
        Tbody tag = new Tbody();
        action(tag);
        return tag;
    }
}