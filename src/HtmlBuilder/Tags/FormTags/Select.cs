namespace HtmlBuilder.Tags.FormTags;
public class Select() : DoubleTagWithChildren("select")
{
    public string SelectName { get; private set; } = string.Empty;
    public bool IsRequired { get; private set; } = false;
    public bool IsDisabled { get; private set; } = false;
    public bool IsMultiple { get; private set; } = false;

    public Select SetName(string name)
    {
        this.SelectName = name;
        this.AddAttribute("name", name);
        return this;
    }

    public Select SetRequired()
    {
        this.IsRequired = true;
        this.AddAttribute("required");
        return this;
    }

    public Select SetDisabled()
    {
        this.IsDisabled = true;
        this.AddAttribute("disabled");
        return this;
    }

    public Select SetMultiple()
    {
        this.IsMultiple = true;
        this.AddAttribute("multiple");
        return this;
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
