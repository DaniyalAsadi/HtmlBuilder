namespace HtmlBuilder.Tags.TableTags;

public class Col() : SingleTag("col")
{
    public int Span { get; private set; }

    public Col SetSpan(int span)
    {
        this.Span = span;
        this.AddAttribute("span", span.ToString());
        return this;
    }
}
