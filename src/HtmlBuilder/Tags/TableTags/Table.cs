namespace HtmlBuilder.Tags.TableTags;
public class Table() : DoubleTagWithChildren("table")
{
    public int Border { get; private set; }
    public string Summary { get; private set; } = string.Empty;

    internal void SetBorder(int border)
    {
        this.Border = border;
        this.AddAttribute("border", border.ToString());
    }

    internal void SetSummary(string summary)
    {
        this.Summary = summary;
        this.AddAttribute("summary", summary);
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}