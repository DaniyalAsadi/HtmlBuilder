namespace HtmlBuilder.Tags.TableTags;

public class Td() : DoubleTagWithChildren("td")
{
    public int Colspan { get; private set; }
    public int Rowspan { get; private set; }
    public string Headers { get; private set; } = string.Empty;

    public Td SetColspan(int colspan)
    {
        this.Colspan = colspan;
        this.AddAttribute("colspan", colspan.ToString());
        return this;
    }

    public Td SetRowspan(int rowspan)
    {
        this.Rowspan = rowspan;
        this.AddAttribute("rowspan", rowspan.ToString());
        return this;
    }

    public Td SetHeaders(string headers)
    {
        this.Headers = headers;
        this.AddAttribute("headers", headers);
        return this;
    }
}

