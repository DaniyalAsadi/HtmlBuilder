namespace HtmlBuilder.Tags;

/// <summary>
/// Represents an HTML &lt;textarea&gt; element.
/// </summary>  
/// <remarks>
/// This class is used to generate a &lt;textarea&gt; element in an HTML document.
/// It inherits from <see cref="DoubleTagWithContent"/> to allow content within the tag.
/// </remarks>
public class TextArea() : DoubleTagWithContent("textarea");
