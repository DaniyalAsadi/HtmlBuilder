using System;

namespace HtmlBuilder.Tags.TableTags;
public static class TrExtensions
{
    public static DoubleHtmlElementWithChildren Tr(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Tr> action)
    {
        Tr tag = new Tr();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}