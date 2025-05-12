using System;

namespace HtmlBuilder.Tags.FormTags;
public static class OutputExtensions
{
    public static DoubleTagWithContent Output(this DoubleTagWithChildren doubleTag, Action<Output> action)
    {
        Output tag = new Output();
        action(tag);
        return tag;
    }
}