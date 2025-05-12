using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class BodyExtensions
{
    public static DoubleTagWithChildren Body(this DoubleTagWithChildren doubleTag, Action<Body> action)
    {
        Body tag = new Body();
        action(tag);
        doubleTag.AddChild(tag);
        return doubleTag;
    }
}