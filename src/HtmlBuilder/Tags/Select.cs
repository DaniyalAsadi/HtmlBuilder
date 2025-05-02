namespace HtmlBuilder.Tags;

public class Select : DoubleTagWithChildren
{
    public Select() : base("select")
    {
    }

    public void SetSelected(string value)
    {
        foreach (var child in Children)
            if (child is Option option)
                if (option.GetAttribute("key") == value) // Use a method to access the attribute
                    option.SetSelected();
    }
}