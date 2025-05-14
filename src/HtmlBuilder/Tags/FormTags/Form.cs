using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.FormTags;
public class Form() : DoubleHtmlElementWithChildren("form")
{
    public string Action { get; private set; } = string.Empty;
    public FormMethod Method { get; private set; } = FormMethod.Get;
    public FormEncryptType EncryptType { get; private set; } = FormEncryptType.UrlEncoded;
    public FormTarget Target { get; private set; } = FormTarget.Self;
    public bool NoValidate { get; private set; } = false;

    internal void SetAction(string action)
    {
        this.Action = action;
        this.AddAttribute("action", action);
    }

    internal void SetMethod(FormMethod method)
    {
        this.Method = method;
        this.AddAttribute("method", method.ToHtmlString());
    }

    internal void SetEncryptType(FormEncryptType encryptType)
    {
        this.EncryptType = encryptType;
        this.AddAttribute("enctype", encryptType.ToHtmlString());
    }

    internal void SetTarget(FormTarget target)
    {
        this.Target = target;
        this.AddAttribute("target", target.ToHtmlString());
    }

    internal void SetNoValidate()
    {
        this.NoValidate = true;
        this.AddAttribute("novalidate");
    }

    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}