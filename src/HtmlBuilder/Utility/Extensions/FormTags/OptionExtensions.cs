using System;

namespace HtmlBuilder.Tags.FormTags;
public static class OptionExtensions
{
    public static DoubleTagWithContent Option(this DoubleTagWithChildren doubleTag, Action<Option> action)
    {
        Option tag = new Option();
        action(tag);
        return tag;
    }
}