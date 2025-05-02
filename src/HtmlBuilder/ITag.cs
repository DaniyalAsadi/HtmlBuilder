namespace HtmlBuilder;

public interface ITag
{
    string Name { get; }
    ITag AddAttribute(string key, string value);
    string Render(int level);
}