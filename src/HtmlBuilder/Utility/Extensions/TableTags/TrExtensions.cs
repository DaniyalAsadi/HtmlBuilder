using System;

namespace HtmlBuilder.Tags.TableTags;
public static class TrExtensions
{
    public static DoubleTagWithChildren Tr(this DoubleTagWithChildren doubleTag, Action<Tr> action)
    {
        Tr tag = new Tr();
        action(tag);
        return tag;
    }
}