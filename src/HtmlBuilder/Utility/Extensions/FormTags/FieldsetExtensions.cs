using System;

namespace HtmlBuilder.Tags.FormTags;
public static class FieldsetExtensions
{
    public static DoubleTagWithChildren Fieldset(this DoubleTagWithChildren doubleTag, Action<Fieldset> action)
    {
        Fieldset tag = new Fieldset();
        action(tag);
        return tag;
    }
}