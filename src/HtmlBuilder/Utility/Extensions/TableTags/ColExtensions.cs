using System;

namespace HtmlBuilder.Tags.TableTags;
public static class ColExtensions
{
    public static Col SetSpan(this Col tag, int span)
    {
        tag.SetSpan(span);
        return tag;
    }

    public static DoubleTagWithChildren Col(this DoubleTagWithChildren doubleTag, Action<Col> action)
    {
        Col tag = new Col();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}