using System;

namespace HtmlBuilder.Tags.FormTags;
public static class TextAreaExtensions
{
    public static DoubleTagWithContent Textarea(this DoubleTagWithChildren doubleTag, Action<Textarea> action)
    {
        Textarea tag = new Textarea();
        action(tag);
        return tag;
    }
}