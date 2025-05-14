using System.Text;

namespace HtmlBuilder.Visitors;

public sealed class MinimalHtmlRenderer : IHtmlVisitor, IHtmlRenderer
{
    private readonly StringBuilder _sb = new();

    public string Render(IHtmlElement htmlElement)
    {
        _sb.Clear();
        htmlElement.Accept(this);
        return _sb.ToString();
    }
    public void Visit(DoubleHtmlElementWithChildren htmlElement)
    {
        _sb.Append('<').Append(htmlElement.Name).Append(htmlElement.RenderAttributes()).Append('>');
        foreach (var child in htmlElement.Children)
        {
            child.Accept(this);
        }
        _sb.Append("</").Append(htmlElement.Name).Append('>');
    }

    public void Visit(SingleHtmlElement htmlElement)
    {
        _sb.Append('<').Append(htmlElement.Name).Append(htmlElement.RenderAttributes()).Append(" />");
    }

    public void Visit(DoubleHtmlElementWithContent htmlElement)
    {
        _sb.Append('<').Append(htmlElement.Name).Append(htmlElement.RenderAttributes()).Append('>');
        if (!string.IsNullOrWhiteSpace(htmlElement.Content))
            _sb.Append(htmlElement.Content);
        _sb.Append("</").Append(htmlElement.Name).Append('>');
    }
}
