using System;

namespace HtmlBuilder.Tags.TableTags;
public static class TfootExtensions
{
    public static Tfoot Tfoot(this DoubleTagWithChildren doubleTag, Action<Tfoot> action)
    {
        Tfoot tag = new Tfoot();
        action(tag);
        return tag;
    }
}