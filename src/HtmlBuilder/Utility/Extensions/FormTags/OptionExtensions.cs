namespace HtmlBuilder.Tags.FormTags;
public static class OptionExtensions
{
    public static Option SetValue(this Option tag, string value)
    {
        tag.SetValue(value);
        return tag;
    }

    public static Option SetSelected(this Option tag)
    {
        tag.SetSelected();
        return tag;
    }

    public static Option SetDisabled(this Option tag)
    {
        tag.SetDisabled();
        return tag;
    }

    public static Option GetAttribute(this Option tag, string key)
    {
        tag.GetAttribute(key);
        return tag;
    }

    public static DoubleHtmlElementWithChildren Option(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Option> action)
    {
        Option tag = new Option();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}