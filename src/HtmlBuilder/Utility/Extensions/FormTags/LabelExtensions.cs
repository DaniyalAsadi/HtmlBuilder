using System;

namespace HtmlBuilder.Tags.FormTags;
public static class LabelExtensions
{
    public static Label Label(this DoubleTagWithChildren doubleTag, Action<Label> action)
    {
        Label tag = new Label();
        action(tag);
        return tag;
    }

    public static Label SetFor(this Label tag, string @for)
    {
        tag.SetFor(@for);
        return tag;
    }
}