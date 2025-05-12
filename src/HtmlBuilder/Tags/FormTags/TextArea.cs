namespace HtmlBuilder.Tags.FormTags;
public class Textarea() : DoubleTagWithContent("textarea")
{
    public string TextareaName { get; private set; } = string.Empty;
    public string Placeholder { get; private set; } = string.Empty;
    public int Rows { get; private set; } = 0;
    public int Cols { get; private set; } = 0;
    public bool IsRequired { get; private set; } = false;
    public bool IsDisabled { get; private set; } = false;

    internal void SetName(string name)
    {
        this.TextareaName = name;
        this.AddAttribute("name", name);
    }

    internal void SetPlaceholder(string placeholder)
    {
        this.Placeholder = placeholder;
        this.AddAttribute("placeholder", placeholder);
    }

    internal void SetRows(int rows)
    {
        this.Rows = rows;
        this.AddAttribute("rows", rows.ToString());
    }

    internal void SetCols(int cols)
    {
        this.Cols = cols;
        this.AddAttribute("cols", cols.ToString());
    }

    internal void SetRequired()
    {
        this.IsRequired = true;
        this.AddAttribute("required");
    }

    internal void SetDisabled()
    {
        this.IsDisabled = true;
        this.AddAttribute("disabled");
    }
}