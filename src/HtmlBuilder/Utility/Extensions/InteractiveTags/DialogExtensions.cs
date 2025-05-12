using System;

namespace HtmlBuilder.Tags.InteractiveTags;
public static class DialogExtensions
{
    public static DoubleTagWithChildren Dialog(this DoubleTagWithChildren doubleTag, Action<Dialog> action)
    {
        Dialog tag = new Dialog();
        action(tag);
        return tag;
    }
}