using System;

namespace HtmlBuilder.Tags.TableTags;
public static class TdExtensions
{
    public static DoubleTagWithChildren Td(this DoubleTagWithChildren doubleTag, Action<Td> action)
    {
        Td tag = new Td();
        action(tag);
        return tag;
    }
}