namespace HtmlBuilder.Tags.TableTags;
public class Th() : DoubleTagWithChildren("th")
{
    public int Colspan { get; private set; }
    public int Rowspan { get; private set; }
    public string Headers { get; private set; } = string.Empty;
    public string Scope { get; private set; } = string.Empty;

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

    internal void SetScope(string scope)
    {
        this.Scope = scope;
        this.AddAttribute("scope", scope);
    }
}