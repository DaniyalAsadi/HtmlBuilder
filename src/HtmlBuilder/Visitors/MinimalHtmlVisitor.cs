using System.Text;

namespace HtmlBuilder.Visitors;

internal sealed class MinimalHtmlVisitor : IHtmlVisitor
{
    private readonly StringBuilder _sb = new();

    public string GetResult() => _sb.ToString();

    public void Visit(DoubleTagWithChildren tag)
    {
        _sb.Append('<').Append(tag.Name).Append(tag.RenderAttributes()).Append('>');
        foreach (var child in tag.Children)
        {
            child.Accept(this);
        }
        _sb.Append("</").Append(tag.Name).Append('>');
    }

    public void Visit(SingleTag tag)
    {
        _sb.Append('<').Append(tag.Name).Append(tag.RenderAttributes()).Append(" />");
    }

    public void Visit(DoubleTagWithContent tag)
    {
        _sb.Append('<').Append(tag.Name).Append(tag.RenderAttributes()).Append('>');
        if (!string.IsNullOrWhiteSpace(tag.Content))
            _sb.Append(tag.Content);
        _sb.Append("</").Append(tag.Name).Append('>');
    }
}
