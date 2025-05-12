namespace HtmlBuilder.Tags.InteractiveTags;
public static class DetailsExtensions
{
    public static Details Details(this DoubleTagWithChildren doubleTag, Action<Details> action)
    {
        Details tag = new Details();
        action(tag);
        return tag;
    }

    public static Details SetOpen(this Details tag)
    {
        tag.SetOpen();
        return tag;
    }
}
