namespace HtmlBuilder;

public abstract class BaseTag : ITag
{
    protected BaseTag(string name)
    {
        Name = name;
    }

    public string Name { get; }
    protected Dictionary<string, string?> Attributes { get; } = new();
    protected HashSet<string> Classes { get; } = new();


    public ITag AddAttribute(string key, string? value = null)
    {
        Attributes[key] = value;
        return this;
    }

    public abstract string Render(int level);

    public ITag AddAttributes(IEnumerable<KeyValuePair<string, string?>> attributes)
    {
        foreach (var attribute in attributes) AddAttribute(attribute.Key, attribute.Value);
        return this;
    }

    public ITag SetId(string id)
    {
        Attributes["id"] = id;
        return this;
    }

    public ITag AddClass(string @class)
    {
        Classes.Add(@class);
        return this;
    }

}