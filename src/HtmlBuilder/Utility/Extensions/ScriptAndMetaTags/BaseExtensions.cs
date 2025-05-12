using System;

namespace HtmlBuilder.Tags.ScriptAndMetaTags;
public static class BaseExtensions
{
    public static SingleTag Base(this DoubleTagWithChildren doubleTag, Action<Base> action)
    {
        Base tag = new Base();
        action(tag);
        return tag;
    }
}