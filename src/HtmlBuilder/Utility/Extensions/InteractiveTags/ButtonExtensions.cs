using System;

namespace HtmlBuilder.Tags.InteractiveTags;
public static class ButtonExtensions
{
    public static DoubleTagWithContent Button(this DoubleTagWithChildren doubleTag, Action<Button> action)
    {
        Button tag = new Button();
        action(tag);
        return tag;
    }
}