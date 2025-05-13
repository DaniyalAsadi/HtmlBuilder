namespace HtmlBuilder;
public interface IHtmlVisitor
{
    void Visit(DoubleTagWithChildren tag);
    void Visit(SingleTag tag);
    void Visit(DoubleTagWithContent tag);
}
