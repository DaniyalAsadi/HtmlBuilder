using System;

namespace HtmlBuilder.Tags.FormTags;
public static class LabelExtensions
{
    public static DoubleTagWithContent Label(this DoubleTagWithChildren doubleTag, Action<Label> action)
    {
        Label tag = new Label();
        action(tag);
        return tag;
    }
}