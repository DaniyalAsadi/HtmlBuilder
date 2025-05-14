namespace HtmlBuilder.Tags.ScriptAndMetaTags;
public class Noscript() : DoubleHtmlElementWithChildren("noscript")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}