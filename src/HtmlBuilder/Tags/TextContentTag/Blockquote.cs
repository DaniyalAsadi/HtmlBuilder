namespace HtmlBuilder.Tags.TextContentTag;

public class Blockquote() : DoubleTagWithContent("blockquote")
{
    public string Cite { get; private set; } = string.Empty;

    public Blockquote SetCite(string cite)
    {
        this.Cite = cite;
        this.AddAttribute("cite", cite);
        return this;
    }
}
