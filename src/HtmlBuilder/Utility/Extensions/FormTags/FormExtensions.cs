using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.FormTags;
public static class FormExtensions
{
    public static Form SetAction(this Form tag, string action)
    {
        tag.SetAction(action);
        return tag;
    }

    public static Form SetMethod(this Form tag, FormMethod method)
    {
        tag.SetMethod(method);
        return tag;
    }

    public static Form SetEnctype(this Form tag, FormEncryptType encryptType)
    {
        tag.SetEnctype(encryptType);
        return tag;
    }

    public static Form SetTarget(this Form tag, FormTarget target)
    {
        tag.SetTarget(target);
        return tag;
    }

    public static Form SetNoValidate(this Form tag)
    {
        tag.SetNoValidate();
        return tag;
    }

    public static DoubleTagWithChildren Form(this DoubleTagWithChildren doubleTag, Action<Form> action)
    {
        Form tag = new Form();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}