namespace HtmlBuilder.Tags.InteractiveTags;
public class Menu() : DoubleTagWithChildren("menu")
{
    public string Type { get; private set; } = string.Empty;
    public string Label { get; private set; } = string.Empty;

    internal void SetType(string type)
    {
        Type = type;
        AddAttribute("type", type);
    }

    internal void SetLabel(string label)
    {
        Label = label;
        AddAttribute("label", label);
    }
}