using System;

namespace HtmlBuilder.Tags.FormTags;
public static class DatalistExtensions
{
    public static DoubleTagWithChildren Datalist(this DoubleTagWithChildren doubleTag, Action<Datalist> action)
    {
        Datalist tag = new Datalist();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}