using System;

namespace HtmlBuilder.Tags.FormTags;
public static class OutputExtensions
{
    public static Output SetName(this Output tag, string name)
    {
        tag.SetName(name);
        return tag;
    }

    public static Output SetForm(this Output tag, string @for)
    {
        tag.SetForm(@for);
        return tag;
    }

    public static DoubleTagWithChildren Output(this DoubleTagWithChildren doubleTag, Action<Output> action)
    {
        Output tag = new Output();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}