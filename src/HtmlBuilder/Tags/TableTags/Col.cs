namespace HtmlBuilder.Tags.TableTags;
public class Col() : SingleTag("col")
{
    public int Span { get; private set; }

    internal void SetSpan(int span)
    {
        this.Span = span;
        this.AddAttribute("span", span.ToString());
    }
}