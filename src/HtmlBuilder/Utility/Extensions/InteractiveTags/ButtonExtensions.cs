using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.InteractiveTags;
public static class ButtonExtensions
{
    public static Button SetDisabled(this Button tag)
    {
        tag.SetDisabled();
        return tag;
    }

    public static Button SetType(this Button tag, ButtonType type)
    {
        tag.SetType(type);
        return tag;
    }

    public static Button SetValue(this Button tag, string value)
    {
        tag.SetValue(value);
        return tag;
    }

    public static DoubleTagWithChildren Button(this DoubleTagWithChildren doubleTag, Action<Button> action)
    {
        Button tag = new Button();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}