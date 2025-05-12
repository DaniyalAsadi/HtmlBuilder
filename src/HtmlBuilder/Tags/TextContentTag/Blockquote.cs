namespace HtmlBuilder.Tags.TextContentTag;
public class Blockquote() : DoubleTagWithContent("blockquote")
{
    public string Cite { get; private set; } = string.Empty;

    internal void SetCite(string cite)
    {
        this.Cite = cite;
        this.AddAttribute("cite", cite);
    }
}