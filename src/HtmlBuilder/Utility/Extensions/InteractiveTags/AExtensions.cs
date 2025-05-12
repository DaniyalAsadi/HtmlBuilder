using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.InteractiveTags;
public static class AExtensions
{
    public static A A(this DoubleTagWithChildren doubleTag, Action<A> action)
    {
        A tag = new A();
        action(tag);
        return tag;
    }

    public static A SetHref(this A tag, string href)
    {
        tag.SetHref(href);
        return tag;
    }

    public static A SetRel(this A tag, string rel)
    {
        tag.SetRel(rel);
        return tag;
    }

    public static A SetType(this A tag, string type)
    {
        tag.SetType(type);
        return tag;
    }

    public static A SetTarget(this A tag, ATarget target)
    {
        tag.SetTarget(target);
        return tag;
    }
}
