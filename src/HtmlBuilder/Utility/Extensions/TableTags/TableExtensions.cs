using System;

namespace HtmlBuilder.Tags.TableTags;
public static class TableExtensions
{
    public static Table SetBorder(this Table tag, int border)
    {
        tag.SetBorder(border);
        return tag;
    }

    public static Table SetSummary(this Table tag, string summary)
    {
        tag.SetSummary(summary);
        return tag;
    }

    public static DoubleTagWithChildren Table(this DoubleTagWithChildren doubleTag, Action<Table> action)
    {
        Table tag = new Table();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}