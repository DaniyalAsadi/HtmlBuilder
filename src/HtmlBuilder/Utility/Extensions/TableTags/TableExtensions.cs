using System;

namespace HtmlBuilder.Tags.TableTags;
public static class TableExtensions
{
    public static DoubleTagWithChildren Table(this DoubleTagWithChildren doubleTag, Action<Table> action)
    {
        Table tag = new Table();
        action(tag);
        return tag;
    }
}