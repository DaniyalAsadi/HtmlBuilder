using System;

namespace HtmlBuilder.Tags.TableTags;
public static class ThExtensions
{
    public static Th SetColspan(this Th tag, int colspan)
    {
        tag.SetColspan(colspan);
        return tag;
    }

    public static Th SetRowspan(this Th tag, int rowspan)
    {
        tag.SetRowspan(rowspan);
        return tag;
    }

    public static Th SetHeaders(this Th tag, string headers)
    {
        tag.SetHeaders(headers);
        return tag;
    }

    public static Th SetScope(this Th tag, string scope)
    {
        tag.SetScope(scope);
        return tag;
    }

    public static DoubleHtmlElementWithChildren Th(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Th> action)
    {
        Th tag = new Th();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}