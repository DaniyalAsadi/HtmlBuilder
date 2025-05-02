namespace HtmlBuilder.Tags;

/// <summary>
/// Represents an HTML &lt;section&gt; element.
/// </summary>
/// <remarks>
/// The &lt;section&gt; element defines a section in an HTML document.
/// This class inherits from <see cref="DoubleTagWithChildren"/> to allow child elements.
/// </remarks>
public class Section() : DoubleTagWithChildren("section");