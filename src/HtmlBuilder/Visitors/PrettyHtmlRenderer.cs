using System.Text;

namespace HtmlBuilder.Visitors;
internal sealed class PrettyHtmlRenderer : IHtmlVisitor, IHtmlRenderer
{
    private readonly StringBuilder _sb = new();
    private int _indentLevel = 0;
    private const int IndentSize = 4;

    public string Render(IHtmlElement htmlElement)
    {
        _sb.Clear();
        htmlElement.Accept(this);
        return _sb.ToString();
    }
    public void Visit(DoubleHtmlElementWithChildren htmlElement)
    {
        WriteOpeningTag(htmlElement.Name, htmlElement.RenderAttributes());

        _indentLevel++;
        foreach (var child in htmlElement.Children)
        {
            child.Accept(this);
        }
        _indentLevel--;

        WriteClosingTag(htmlElement.Name);
    }

    public void Visit(SingleHtmlElement htmlElement)
    {
        WriteSelfClosingTag(htmlElement.Name, htmlElement.RenderAttributes());
    }

    public void Visit(DoubleHtmlElementWithContent htmlElement)
    {
        var indent = Indent();
        _sb.Append(indent)
            .Append('<').Append(htmlElement.Name).Append(htmlElement.RenderAttributes()).Append('>');

        if (!string.IsNullOrWhiteSpace(htmlElement.Content))
        {
            _sb.Append(htmlElement.Content);
        }

        _sb.Append("</").Append(htmlElement.Name).AppendLine(">");
    }

    private void WriteOpeningTag(string tagName, string attributes)
    {
        var indent = Indent();
        _sb.Append(indent)
            .Append('<').Append(tagName).Append(attributes).AppendLine(">");
    }

    private void WriteClosingTag(string tagName)
    {
        var indent = Indent();
        _sb.Append(indent)
            .Append("</").Append(tagName).AppendLine(">");
    }

    private void WriteSelfClosingTag(string tagName, string attributes)
    {
        var indent = Indent();
        _sb.Append(indent)
            .Append('<').Append(tagName).Append(attributes).AppendLine(" />");
    }

    private string Indent() => new string(' ', _indentLevel * IndentSize);
}
