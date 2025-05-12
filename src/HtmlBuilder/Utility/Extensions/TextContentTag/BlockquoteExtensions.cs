using System;

namespace HtmlBuilder.Tags.TextContentTag;
public static class BlockquoteExtensions
{
    public static Blockquote Blockquote(this DoubleTagWithChildren doubleTag, Action<Blockquote> action)
    {
        Blockquote tag = new Blockquote();
        action(tag);
        return tag;
    }

    public static Blockquote SetCite(this Blockquote tag, string cite)
    {
        tag.SetCite(cite);
        return tag;
    }
}