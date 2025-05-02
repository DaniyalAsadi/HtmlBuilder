namespace HtmlBuilder.Tags;

/// <summary>
/// Represents an HTML &lt;article&gt; element.
/// </summary>
/// <remarks>
/// The &lt;article&gt; element defines an independent piece of content in an HTML document.
/// This class inherits from <see cref="DoubleTagWithChildren"/> to allow child elements.
/// </remarks>
public class Article() : DoubleTagWithChildren("article");