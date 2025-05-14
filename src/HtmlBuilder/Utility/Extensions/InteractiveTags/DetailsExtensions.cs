namespace HtmlBuilder.Tags.InteractiveTags;
public static class DetailsExtensions
{
    public static Details SetOpen(this Details tag)
    {
        tag.SetOpen();
        return tag;
    }

    public static DoubleHtmlElementWithChildren Details(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Details> action)
    {
        Details tag = new Details();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}