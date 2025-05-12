using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.FormTags;
public static class InputExtensions
{
    public static Input Input(this DoubleTagWithChildren doubleTag, Action<Input> action)
    {
        Input tag = new Input();
        action(tag);
        return tag;
    }

    public static Input SetType(this Input tag, InputType type)
    {
        tag.SetType(type);
        return tag;
    }

    public static Input SetValue(this Input tag, string defaultValue)
    {
        tag.SetValue(defaultValue);
        return tag;
    }

    public static Input AddRegex(this Input tag, string regex)
    {
        tag.AddRegex(regex);
        return tag;
    }
}
