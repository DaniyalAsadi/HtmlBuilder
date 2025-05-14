using System;

namespace HtmlBuilder.Tags.TableTags;
public static class CaptionExtensions
{
    public static DoubleHtmlElementWithChildren Caption(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Caption> action)
    {
        Caption tag = new Caption();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}