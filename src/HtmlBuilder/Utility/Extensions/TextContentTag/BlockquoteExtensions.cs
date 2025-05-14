using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class BlockquoteExtensions
{
    public static Blockquote SetCite(this Blockquote tag, string cite)
    {
        tag.SetCite(cite);
        return tag;
    }

    public static DoubleHtmlElementWithChildren Blockquote(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Blockquote> action)
    {
        Blockquote tag = new Blockquote();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}