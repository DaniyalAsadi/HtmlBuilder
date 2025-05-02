namespace HtmlBuilder;

public class HtmlBuilder
{
    public static TTag Create<TTag>(Action<TTag>? creator = null)
        where TTag : DoubleTagWithChildren, new()
    {
        var element = new TTag();
        creator?.Invoke(element);
        return element;
    }
}