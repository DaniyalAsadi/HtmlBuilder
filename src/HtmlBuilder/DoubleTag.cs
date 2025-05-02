namespace HtmlBuilder;


/// <summary>
/// Represents an abstract base class for HTML tags that have both opening and closing tags.
/// </summary>
/// <param name="name">The name of the HTML tag (e.g., "div", "span").</param>
public abstract class DoubleTag(string name) : BaseTag(name);
