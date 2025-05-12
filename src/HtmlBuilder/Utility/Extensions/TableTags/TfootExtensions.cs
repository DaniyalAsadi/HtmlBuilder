using System;

namespace HtmlBuilder.Tags.TableTags;
public static class TfootExtensions
{
    public static DoubleTagWithChildren Tfoot(this DoubleTagWithChildren doubleTag, Action<Tfoot> action)
    {
        Tfoot tag = new Tfoot();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}