using System;

namespace HtmlBuilder.Tags.InteractiveTags;
public static class MenuExtensions
{
    public static Menu Menu(this DoubleTagWithChildren doubleTag, Action<Menu> action)
    {
        Menu tag = new Menu();
        action(tag);
        return tag;
    }

    public static Menu SetType(this Menu tag, string type)
    {
        tag.SetType(type);
        return tag;
    }

    public static Menu SetLabel(this Menu tag, string label)
    {
        tag.SetLabel(label);
        return tag;
    }
}