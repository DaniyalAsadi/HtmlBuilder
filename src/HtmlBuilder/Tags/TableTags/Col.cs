namespace HtmlBuilder.Tags.TableTags;
public class Col() : SingleHtmlElement("col")
{
    public int Span { get; private set; }

    internal void SetSpan(int span)
    {
        this.Span = span;
        this.AddAttribute("span", span.ToString());
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}