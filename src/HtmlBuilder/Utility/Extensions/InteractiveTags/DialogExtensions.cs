namespace HtmlBuilder.Tags.InteractiveTags;
public static class DialogExtensions
{
    public static Dialog SetOpen(this Dialog tag)
    {
        tag.SetOpen();
        return tag;
    }

    public static DoubleTagWithChildren Dialog(this DoubleTagWithChildren doubleTag, Action<Dialog> action)
    {
        Dialog tag = new Dialog();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}