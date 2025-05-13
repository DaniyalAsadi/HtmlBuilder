namespace HtmlBuilder.Tags.TableTags;
public class Td() : DoubleTagWithChildren("td")
{
    public int Colspan { get; private set; }
    public int Rowspan { get; private set; }
    public string Headers { get; private set; } = string.Empty;

    internal void SetColspan(int colspan)
    {
        this.Colspan = colspan;
        this.AddAttribute("colspan", colspan.ToString());
    }

    internal void SetRowspan(int rowspan)
    {
        this.Rowspan = rowspan;
        this.AddAttribute("rowspan", rowspan.ToString());
    }

    internal void SetHeaders(string headers)
    {
        this.Headers = headers;
        this.AddAttribute("headers", headers);
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}