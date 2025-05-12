using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class BodyExtensions
{
    public static Body Body(this DoubleTagWithChildren doubleTag, Action<Body> action)
    {
        Body tag = new Body();
        action(tag);
        return tag;
    }
}