using System;

namespace HtmlBuilder.Tags.TableTags;
public static class ThExtensions
{
    public static DoubleTagWithChildren Th(this DoubleTagWithChildren doubleTag, Action<Th> action)
    {
        Th tag = new Th();
        action(tag);
        return tag;
    }
}