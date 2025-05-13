using System.Text;

namespace HtmlBuilder.Visitors;
internal sealed class PrettyHtmlRenderer : IHtmlVisitor, IHtmlRenderer
{
    private readonly StringBuilder _sb = new();
    private int _indentLevel = 0;
    private const int IndentSize = 4;

    public string Render(BaseTag tag)
    {
        _sb.Clear();
        tag.Accept(this);
        return _sb.ToString();
    }
    public void Visit(DoubleTagWithChildren tag)
    {
        WriteOpeningTag(tag.Name, tag.RenderAttributes());

        _indentLevel++;
        foreach (var child in tag.Children)
        {
            child.Accept(this);
        }
        _indentLevel--;

        WriteClosingTag(tag.Name);
    }

    public void Visit(SingleTag tag)
    {
        WriteSelfClosingTag(tag.Name, tag.RenderAttributes());
    }

    public void Visit(DoubleTagWithContent tag)
    {
        var indent = Indent();
        _sb.Append(indent)
            .Append('<').Append(tag.Name).Append(tag.RenderAttributes()).Append('>');

        if (!string.IsNullOrWhiteSpace(tag.Content))
        {
            _sb.Append(tag.Content);
        }

        _sb.Append("</").Append(tag.Name).AppendLine(">");
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
