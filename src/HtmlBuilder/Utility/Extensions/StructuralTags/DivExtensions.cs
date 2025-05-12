using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class DivExtensions
{
    public static Div Div(this DoubleTagWithChildren doubleTag, Action<Div> action)
    {
        Div tag = new Div();
        action(tag);
        return tag;
    }
}