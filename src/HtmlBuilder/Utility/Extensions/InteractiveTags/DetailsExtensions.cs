using System;

namespace HtmlBuilder.Tags.InteractiveTags;
public static class DetailsExtensions
{
    public static DoubleTagWithChildren Details(this DoubleTagWithChildren doubleTag, Action<Details> action)
    {
        Details tag = new Details();
        action(tag);
        return tag;
    }
}