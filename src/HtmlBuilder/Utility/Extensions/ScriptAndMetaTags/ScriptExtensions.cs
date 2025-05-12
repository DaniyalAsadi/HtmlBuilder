namespace HtmlBuilder.Tags.ScriptAndMetaTags;
public static class ScriptExtensions
{
    public static Script SetSrc(this Script tag, string src)
    {
        tag.SetSrc(src);
        return tag;
    }

    public static Script SetType(this Script tag, string type)
    {
        tag.SetType(type);
        return tag;
    }

    public static Script SetAsync(this Script tag)
    {
        tag.SetAsync();
        return tag;
    }

    public static Script SetDefer(this Script tag)
    {
        tag.SetDefer();
        return tag;
    }

    public static DoubleTagWithChildren Script(this DoubleTagWithChildren doubleTag, Action<Script> action)
    {
        Script tag = new Script();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}