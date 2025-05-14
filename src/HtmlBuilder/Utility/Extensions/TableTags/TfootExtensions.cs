using System;

namespace HtmlBuilder.Tags.TableTags;
public static class TfootExtensions
{
    public static DoubleHtmlElementWithChildren Tfoot(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Tfoot> action)
    {
        Tfoot tag = new Tfoot();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}