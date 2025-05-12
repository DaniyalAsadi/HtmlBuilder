namespace HtmlBuilder.Tags.InteractiveTags;
public static class DialogExtensions
{
    public static Dialog Dialog(this DoubleTagWithChildren doubleTag, Action<Dialog> action)
    {
        Dialog tag = new Dialog();
        action(tag);
        return tag;
    }

    public static Dialog SetOpen(this Dialog tag)
    {
        tag.SetOpen();
        return tag;
    }
}
