namespace HtmlBuilder.Tags.StructuralTags;
public static class DivExtensions
{
    public static DoubleHtmlElementWithChildren Div(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Div> action)
    {
        Div tag = new Div();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}