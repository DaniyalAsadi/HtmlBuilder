namespace HtmlBuilder.Tags.TextContentTag;
public static class OlExtensions
{
    public static Ol Ol(this DoubleTagWithChildren doubleTag, Action<Ol> action)
    {
        Ol tag = new Ol();
        action(tag);
        return tag;
    }

    public static Ol SetType(this Ol tag, string type)
    {
        tag.SetType(type);
        return tag;
    }

    public static Ol SetStart(this Ol tag, int start)
    {
        tag.SetStart(start);
        return tag;
    }

    public static Ol SetReversed(this Ol tag)
    {
        tag.SetReversed();
        return tag;
    }
}
