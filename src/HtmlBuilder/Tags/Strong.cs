namespace HtmlBuilder.Tags;

/// <summary>
/// Represents an HTML &lt;strong&gt; element.
/// </summary>
/// <remarks>
/// The &lt;strong&gt; element is used to define important text in an HTML document.
/// This class inherits from <see cref="DoubleTagWithContent"/> to allow textual content.
/// </remarks>
public class Strong() : DoubleTagWithContent("strong");