using System;

namespace HtmlBuilder.Tags.FormTags;
public static class DatalistExtensions
{
    public static DoubleHtmlElementWithChildren Datalist(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Datalist> action)
    {
        Datalist tag = new Datalist();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}