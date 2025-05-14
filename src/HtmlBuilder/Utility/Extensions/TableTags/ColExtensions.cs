using System;

namespace HtmlBuilder.Tags.TableTags;
public static class ColExtensions
{
    public static Col SetSpan(this Col tag, int span)
    {
        tag.SetSpan(span);
        return tag;
    }

    public static DoubleHtmlElementWithChildren Col(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Col> action)
    {
        Col tag = new Col();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}