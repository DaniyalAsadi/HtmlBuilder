namespace HtmlBuilder.Tags.StructuralTags;

public class Body() : DoubleTagWithChildren("body")
{

    public Body SetOnLoad(string script)
    {
        this.AddAttribute("onload", script);
        return this;
    }

    public Body SetOnUnload(string script)
    {
        this.AddAttribute("onunload", script);
        return this;
    }
}