using System;

namespace HtmlBuilder.Tags.FormTags;
public static class LabelExtensions
{
    public static Label SetFor(this Label tag, string @for)
    {
        tag.SetFor(@for);
        return tag;
    }

    public static DoubleTagWithChildren Label(this DoubleTagWithChildren doubleTag, Action<Label> action)
    {
        Label tag = new Label();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}