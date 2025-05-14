namespace HtmlBuilder;
public interface IHtmlVisitor
{
    void Visit(DoubleHtmlElementWithChildren htmlElement);
    void Visit(SingleHtmlElement htmlElement);
    void Visit(DoubleHtmlElementWithContent htmlElement);
}
