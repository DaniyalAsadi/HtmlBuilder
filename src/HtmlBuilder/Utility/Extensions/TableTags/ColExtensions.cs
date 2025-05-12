using System;

namespace HtmlBuilder.Tags.TableTags;
public static class ColExtensions
{
    public static Col Col(this DoubleTagWithChildren doubleTag, Action<Col> action)
    {
        Col tag = new Col();
        action(tag);
        return tag;
    }

    public static Col SetSpan(this Col tag, int span)
    {
        tag.SetSpan(span);
        return tag;
    }
}