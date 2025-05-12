namespace HtmlBuilder.Tags.FormTags;
public static class SelectExtensions
{
    public static Select Select(this DoubleTagWithChildren doubleTag, Action<Select> action)
    {
        Select tag = new Select();
        action(tag);
        return tag;
    }

    public static Select SetName(this Select tag, string name)
    {
        tag.SetName(name);
        return tag;
    }

    public static Select SetRequired(this Select tag)
    {
        tag.SetRequired();
        return tag;
    }

    public static Select SetDisabled(this Select tag)
    {
        tag.SetDisabled();
        return tag;
    }

    public static Select SetMultiple(this Select tag)
    {
        tag.SetMultiple();
        return tag;
    }

    public static Select SetSelected(this Select tag, string value)
    {
        tag.SetSelected(value);
        return tag;
    }
}
