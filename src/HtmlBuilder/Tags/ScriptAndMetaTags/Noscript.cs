namespace HtmlBuilder.Tags.ScriptAndMetaTags;
public class Noscript() : DoubleTagWithChildren("noscript")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}