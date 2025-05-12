namespace HtmlBuilder.Tags.FormTags;
public class Fieldset() : DoubleTagWithChildren("fieldset")
{
    public string FieldsetName { get; set; } = string.Empty;
    public string Form { get; private set; } = string.Empty;
    public bool IsDisabled { get; private set; } = false;

    internal void SetName(string name)
    {
        this.FieldsetName = name;
        this.AddAttribute("name", name);
    }

    internal void SetForm(string form)
    {
        this.Form = form;
        this.AddAttribute("form", form);
    }

    internal void SetDisabled()
    {
        this.IsDisabled = true;
        this.AddAttribute("disabled");
    }
}