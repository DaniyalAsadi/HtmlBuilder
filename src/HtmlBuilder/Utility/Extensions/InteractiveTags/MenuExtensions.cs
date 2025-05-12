using System;

namespace HtmlBuilder.Tags.InteractiveTags;
public static class MenuExtensions
{
    public static DoubleTagWithChildren Menu(this DoubleTagWithChildren doubleTag, Action<Menu> action)
    {
        Menu tag = new Menu();
        action(tag);
        return tag;
    }
}