namespace HtmlBuilder.Tags;

/// <summary>
/// Represents an HTML &lt;a&gt; tag.
/// </summary>
/// <remarks>
/// The &lt;a&gt; tag defines a hyperlink in an HTML document.
/// This class inherits from <see cref="DoubleTagWithContent"/> to allow textual content.
/// </remarks>
public class A() : DoubleTagWithContent("a");