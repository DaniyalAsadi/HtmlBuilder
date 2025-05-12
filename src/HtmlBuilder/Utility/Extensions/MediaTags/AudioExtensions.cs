namespace HtmlBuilder.Tags.MediaTags;
public static class AudioExtensions
{
    public static Audio SetSrc(this Audio tag, string src)
    {
        tag.SetSrc(src);
        return tag;
    }

    public static Audio SetControls(this Audio tag)
    {
        tag.SetControls();
        return tag;
    }

    public static Audio SetAutoplay(this Audio tag)
    {
        tag.SetAutoplay();
        return tag;
    }

    public static Audio SetLoop(this Audio tag)
    {
        tag.SetLoop();
        return tag;
    }

    public static Audio SetMuted(this Audio tag)
    {
        tag.SetMuted();
        return tag;
    }

    public static DoubleTagWithChildren Audio(this DoubleTagWithChildren doubleTag, Action<Audio> action)
    {
        Audio tag = new Audio();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}