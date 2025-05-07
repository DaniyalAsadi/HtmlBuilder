namespace HtmlBuilder.Tags.FormTags;
public class Select() : DoubleTagWithChildren("select")
{
    public void SetSelected(string value)
    {
        foreach (var child in this.Children.OfType<Option>())
        {
            if (child.GetAttribute("key") == value)
            {
                child.SetSelected();
            }
        }
    }
}