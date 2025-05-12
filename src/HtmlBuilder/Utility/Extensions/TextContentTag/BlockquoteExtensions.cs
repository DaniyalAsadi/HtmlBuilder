using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class BlockquoteExtensions
{
    public static DoubleTagWithContent Blockquote(this DoubleTagWithChildren doubleTag, Action<Blockquote> action)
    {
        Blockquote tag = new Blockquote();
        action(tag);
        return tag;
    }
}