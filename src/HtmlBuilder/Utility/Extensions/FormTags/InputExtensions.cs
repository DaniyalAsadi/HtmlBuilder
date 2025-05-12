using System;

namespace HtmlBuilder.Tags.FormTags;
public static class InputExtensions
{
    public static SingleTag Input(this DoubleTagWithChildren doubleTag, Action<Input> action)
    {
        Input tag = new Input();
        action(tag);
        return tag;
    }
}