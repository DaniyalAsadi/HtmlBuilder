namespace HtmlBuilder.Tags;

/// <summary>
/// Represents an HTML &lt;div&gt; element.
/// </summary>
/// <remarks>
/// The &lt;div&gt; element is a container for grouping and styling content in an HTML document.
/// This class inherits from <see cref="DoubleTagWithChildren"/> to allow child elements.
/// </remarks>
public class Div() : DoubleTagWithChildren("div");
