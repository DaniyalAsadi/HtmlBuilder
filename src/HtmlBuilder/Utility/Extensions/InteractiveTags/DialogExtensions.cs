namespace HtmlBuilder.Tags.InteractiveTags;
public static class DialogExtensions
{
    public static Dialog SetOpen(this Dialog tag)
    {
        tag.SetOpen();
        return tag;
    }

    public static DoubleHtmlElementWithChildren Dialog(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Dialog> action)
    {
        Dialog tag = new Dialog();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}