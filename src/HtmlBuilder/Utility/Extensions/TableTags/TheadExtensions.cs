using System;

namespace HtmlBuilder.Tags.TableTags;
public static class TheadExtensions
{
    public static DoubleHtmlElementWithChildren Thead(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Thead> action)
    {
        Thead tag = new Thead();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}