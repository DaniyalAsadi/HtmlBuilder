using System;

namespace HtmlBuilder.Tags.ScriptAndMetaTags;
public static class ScriptExtensions
{
    public static DoubleTagWithContent Script(this DoubleTagWithChildren doubleTag, Action<Script> action)
    {
        Script tag = new Script();
        action(tag);
        return tag;
    }
}