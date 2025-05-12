using System;

namespace HtmlBuilder.Tags.FormTags;
public static class DatalistExtensions
{
    public static Datalist Datalist(this DoubleTagWithChildren doubleTag, Action<Datalist> action)
    {
        Datalist tag = new Datalist();
        action(tag);
        return tag;
    }
}