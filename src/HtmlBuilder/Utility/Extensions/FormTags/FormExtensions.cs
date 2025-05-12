using System;

namespace HtmlBuilder.Tags.FormTags;
public static class FormExtensions
{
    public static DoubleTagWithChildren Form(this DoubleTagWithChildren doubleTag, Action<Form> action)
    {
        Form tag = new Form();
        action(tag);
        return tag;
    }
}