using System;

namespace HtmlBuilder.Tags.FormTags;
public static class SelectExtensions
{
    public static DoubleTagWithChildren Select(this DoubleTagWithChildren doubleTag, Action<Select> action)
    {
        Select tag = new Select();
        action(tag);
        return tag;
    }
}