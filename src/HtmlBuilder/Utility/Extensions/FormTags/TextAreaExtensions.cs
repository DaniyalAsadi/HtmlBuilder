namespace HtmlBuilder.Tags.FormTags;
public static class TextAreaExtensions
{
    public static Textarea SetName(this Textarea tag, string name)
    {
        tag.SetName(name);
        return tag;
    }

    public static Textarea SetPlaceholder(this Textarea tag, string placeholder)
    {
        tag.SetPlaceholder(placeholder);
        return tag;
    }

    public static Textarea SetRows(this Textarea tag, int rows)
    {
        tag.SetRows(rows);
        return tag;
    }

    public static Textarea SetCols(this Textarea tag, int cols)
    {
        tag.SetCols(cols);
        return tag;
    }

    public static Textarea SetRequired(this Textarea tag)
    {
        tag.SetRequired();
        return tag;
    }

    public static Textarea SetDisabled(this Textarea tag)
    {
        tag.SetDisabled();
        return tag;
    }

    public static DoubleHtmlElementWithChildren Textarea(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Textarea> action)
    {
        Textarea tag = new Textarea();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
