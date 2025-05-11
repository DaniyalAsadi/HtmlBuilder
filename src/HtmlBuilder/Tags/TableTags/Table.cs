namespace HtmlBuilder.Tags.TableTags;
public class Table() : DoubleTagWithChildren("table")
{
    public int Border { get; private set; }
    public string Summary { get; private set; } = string.Empty;

    public Table SetBorder(int border)
    {
        this.Border = border;
        this.AddAttribute("border", border.ToString());
        return this;
    }

    public Table SetSummary(string summary)
    {
        this.Summary = summary;
        this.AddAttribute("summary", summary);
        return this;
    }

}

