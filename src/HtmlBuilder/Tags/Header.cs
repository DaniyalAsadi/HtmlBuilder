namespace HtmlBuilder.Tags;

/// <summary>
/// Represents an HTML &lt;header&gt; element.
/// </summary>
/// <remarks>
/// The &lt;header&gt; element defines a header for a document or section in an HTML document.
/// This class inherits from <see cref="DoubleTagWithChildren"/> to allow child elements.
/// </remarks>
public class Header() : DoubleTagWithChildren("header");