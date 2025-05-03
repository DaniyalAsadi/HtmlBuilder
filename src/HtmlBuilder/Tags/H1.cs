namespace HtmlBuilder.Tags;

public class H1 : DoubleTagWithContent
{
    public H1() : base("h1")
    {
    }
}

public static class H1Extensions
{
    public static DoubleTagWithChildren H1(this DoubleTagWithChildren tag, string content)
    {
        var h1 = new H1();
        h1.SetContent(content);
        tag.AddChild(h1);
        return tag;

    }
}