using System;

namespace HtmlBuilder.Tags.TableTags;
public static class ColExtensions
{
    public static SingleTag Col(this DoubleTagWithChildren doubleTag, Action<Col> action)
    {
        Col tag = new Col();
        action(tag);
        return tag;
    }
}