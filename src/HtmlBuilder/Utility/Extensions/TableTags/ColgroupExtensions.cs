using System;

namespace HtmlBuilder.Tags.TableTags;
public static class ColgroupExtensions
{
    public static Colgroup SetSpan(this Colgroup tag, int span)
    {
        tag.SetSpan(span);
        return tag;
    }

    public static DoubleHtmlElementWithChildren Colgroup(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Colgroup> action)
    {
        Colgroup tag = new Colgroup();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}