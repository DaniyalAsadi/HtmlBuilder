namespace HtmlBuilder.Tags.TextContentTag;
public class H5() : DoubleTagWithContent("h5")
{
    public override void Accept(IHtmlVisitor visitor)
    {
        visitor.Visit(this);
    }
}