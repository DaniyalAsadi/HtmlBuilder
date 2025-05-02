namespace HtmlBuilder.Tags;

/// <summary>
/// Represents an HTML &lt;footer&gt; element.
/// </summary>
/// <remarks>
/// The &lt;footer&gt; element defines a footer for a document or section in an HTML document.
/// This class inherits from <see cref="DoubleTagWithChildren"/> to allow child elements.
/// </remarks>
public class Footer() : DoubleTagWithChildren("footer");