namespace HtmlBuilder.Tags.FormTags;
public static class FieldsetExtensions
{
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

    public static DoubleHtmlElementWithChildren Fieldset(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Fieldset> action)
    {
        Fieldset tag = new Fieldset();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}