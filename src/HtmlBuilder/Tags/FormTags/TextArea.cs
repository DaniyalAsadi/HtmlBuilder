namespace HtmlBuilder.Tags.FormTags;

public class Textarea() : DoubleTagWithContent("textarea")
{
    public string TextareaName { get; private set; } = string.Empty;
    public string Placeholder { get; private set; } = string.Empty;
    public int Rows { get; private set; } = 0;
    public int Cols { get; private set; } = 0;
    public bool IsRequired { get; private set; } = false;
    public bool IsDisabled { get; private set; } = false;

    public Textarea SetName(string name)
    {
        this.TextareaName = name;
        this.AddAttribute("name", name);
        return this;
    }

    public Textarea SetPlaceholder(string placeholder)
    {
        this.Placeholder = placeholder;
        this.AddAttribute("placeholder", placeholder);
        return this;
    }

    public Textarea SetRows(int rows)
    {
        this.Rows = rows;
        this.AddAttribute("rows", rows.ToString());
        return this;
    }

    public Textarea SetCols(int cols)
    {
        this.Cols = cols;
        this.AddAttribute("cols", cols.ToString());
        return this;
    }

    public Textarea SetRequired()
    {
        this.IsRequired = true;
        this.AddAttribute("required");
        return this;
    }

    public Textarea SetDisabled()
    {
        this.IsDisabled = true;
        this.AddAttribute("disabled");
        return this;
    }
}
