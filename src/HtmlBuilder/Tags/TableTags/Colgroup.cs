namespace HtmlBuilder.Tags.TableTags;

public class Colgroup() : DoubleTagWithChildren("colgroup")
{
    public int Span { get; private set; }
    public Colgroup SetSpan(int span)
    {
        this.Span = span;
        this.AddAttribute("span", span.ToString());
        return this;
    }
}
