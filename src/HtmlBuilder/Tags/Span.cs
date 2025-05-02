namespace HtmlBuilder.Tags;

/// <summary>
/// Represents an HTML &lt;span&gt; element.
/// </summary>
/// <remarks>
/// The &lt;span&gt; element is used to group inline elements in an HTML document.
/// This class inherits from <see cref="DoubleTagWithContent"/> to allow textual content.
/// </remarks>
public class Span() : DoubleTagWithContent("span");