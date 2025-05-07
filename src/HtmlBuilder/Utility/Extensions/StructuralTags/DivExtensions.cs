using HtmlBuilder.Tags.StructuralTags;

namespace HtmlBuilder.Utility.Extensions.StructuralTags;

public static class DivExtensions
{
    public static DoubleTagWithChildren Div(this DoubleTagWithChildren tag,
        Action<Div>? action = null)
    {
        var div = new Div();
        if (action != null)
            action(div);
        tag.AddChild(div);
        return div;
    }
}
