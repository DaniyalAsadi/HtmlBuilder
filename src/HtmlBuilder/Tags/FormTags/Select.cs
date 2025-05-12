namespace HtmlBuilder.Tags.FormTags;
public class Select() : DoubleTagWithChildren("select")
{
    public string SelectName { get; private set; } = string.Empty;
    public bool IsRequired { get; private set; } = false;
    public bool IsDisabled { get; private set; } = false;
    public bool IsMultiple { get; private set; } = false;

    internal void SetName(string name)
    {
        this.SelectName = name;
        this.AddAttribute("name", name);
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

    internal void SetMultiple()
    {
        this.IsMultiple = true;
        this.AddAttribute("multiple");
    }

    public void SetSelected(string value)
    {
        foreach (var child in this.Children.OfType<Option>())
        {
            if (child.GetAttribute("key") == value)
            {
                child.SetSelected();
            }
        }
    }
}