namespace HtmlBuilder.Tags.FormTags;
public static class FieldsetExtensions
{
    public static Fieldset Fieldset(this DoubleTagWithChildren doubleTag, Action<Fieldset> action)
    {
        Fieldset tag = new Fieldset();
        action(tag);
        return tag;
    }

    public static Fieldset SetName(this Fieldset tag, string name)
    {
        tag.SetName(name);
        return tag;
    }

    public static Fieldset SetForm(this Fieldset tag, string form)
    {
        tag.SetForm(form);
        return tag;
    }

    public static Fieldset SetDisabled(this Fieldset tag)
    {
        tag.SetDisabled();
        return tag;
    }
}
