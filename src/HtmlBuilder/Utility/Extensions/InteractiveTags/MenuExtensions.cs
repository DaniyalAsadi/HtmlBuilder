using System;

namespace HtmlBuilder.Tags.InteractiveTags;
public static class MenuExtensions
{
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

    public static DoubleHtmlElementWithChildren Menu(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Menu> action)
    {
        Menu tag = new Menu();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}