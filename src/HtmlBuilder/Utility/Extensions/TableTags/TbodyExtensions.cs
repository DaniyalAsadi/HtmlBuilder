using System;

namespace HtmlBuilder.Tags.TableTags;
public static class TbodyExtensions
{
    public static DoubleHtmlElementWithChildren Tbody(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Tbody> action)
    {
        Tbody tag = new Tbody();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}