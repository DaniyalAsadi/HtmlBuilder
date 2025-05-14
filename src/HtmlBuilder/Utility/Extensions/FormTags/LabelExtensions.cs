using System;

namespace HtmlBuilder.Tags.FormTags;
public static class LabelExtensions
{
    public static Label SetFor(this Label tag, string @for)
    {
        tag.SetFor(@for);
        return tag;
    }

    public static DoubleHtmlElementWithChildren Label(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Label> action)
    {
        Label tag = new Label();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}