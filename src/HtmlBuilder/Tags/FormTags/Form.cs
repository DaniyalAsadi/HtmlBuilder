using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.FormTags;
public class Form() : DoubleTagWithChildren("form")
{
    public string Action { get; private set; } = string.Empty;
    public FormMethod Method { get; private set; } = FormMethod.Get;
    public FormEnctype Enctype { get; private set; } = FormEnctype.UrlEncoded;
    public FormTarget Target { get; private set; } = FormTarget._Self;
    public bool NoValidate { get; private set; } = false;

    internal void SetAction(string action)
    {
        this.Action = action;
        this.AddAttribute("action", action);
    }

    internal void SetMethod(FormMethod method)
    {
        this.Method = method;
        this.AddAttribute("method", method.ToString().ToLower());
    }

    internal void SetEnctype(FormEnctype enctype)
    {
        this.Enctype = enctype;
        this.AddAttribute("enctype", enctype.ToString().ToLower());
    }

    internal void SetTarget(FormTarget target)
    {
        this.Target = target;
        this.AddAttribute("target", target.ToString().ToLower());
    }

    internal void SetNoValidate()
    {
        this.NoValidate = true;
        this.AddAttribute("novalidate");
    }
}