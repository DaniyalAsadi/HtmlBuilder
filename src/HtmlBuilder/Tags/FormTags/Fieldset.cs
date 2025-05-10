namespace HtmlBuilder.Tags.FormTags;

public class Fieldset() : DoubleTagWithChildren("fieldset")
{
    public string FieldsetName { get; set; } = string.Empty;
    public string Form { get; private set; } = string.Empty;
    public bool IsDisabled { get; private set; } = false;

    public Fieldset SetName(string name)
    {
        this.FieldsetName = name;
        this.AddAttribute("name", name);
        return this;
    }

    public Fieldset SetForm(string form)
    {
        this.Form = form;
        this.AddAttribute("form", form);
        return this;
    }

    public Fieldset SetDisabled()
    {
        this.IsDisabled = true;
        this.AddAttribute("disabled");
        return this;
    }
}
