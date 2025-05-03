namespace HtmlBuilder.Tags;

public class H1 : DoubleTagWithContent
{
    public H1() : base("h1")
    {
    }
}

public static class H1Extensions
{
    public static DoubleTagWithChildren H1(this DoubleTagWithChildren tag, Action<H1> action)
    {
        var h1 = new H1();
        action(h1);
        tag.AddChild(h1);
        return tag;

    }
}