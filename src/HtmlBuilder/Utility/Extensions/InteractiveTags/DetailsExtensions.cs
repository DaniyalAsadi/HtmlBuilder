namespace HtmlBuilder.Tags.InteractiveTags;
public static class DetailsExtensions
{
    public static Details SetOpen(this Details tag)
    {
        tag.SetOpen();
        return tag;
    }

    public static DoubleTagWithChildren Details(this DoubleTagWithChildren doubleTag, Action<Details> action)
    {
        Details tag = new Details();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}