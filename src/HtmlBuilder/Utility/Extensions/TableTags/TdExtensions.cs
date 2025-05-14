using System;

namespace HtmlBuilder.Tags.TableTags;
public static class TdExtensions
{
    public static Td SetColspan(this Td tag, int colspan)
    {
        tag.SetColspan(colspan);
        return tag;
    }

    public static Td SetRowspan(this Td tag, int rowspan)
    {
        tag.SetRowspan(rowspan);
        return tag;
    }

    public static Td SetHeaders(this Td tag, string headers)
    {
        tag.SetHeaders(headers);
        return tag;
    }

    public static DoubleHtmlElementWithChildren Td(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Td> action)
    {
        Td tag = new Td();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}