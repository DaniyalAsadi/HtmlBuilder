namespace HtmlBuilder.Tags;

/// <summary>
/// Represents the root &lt;html&gt; tag in an HTML document.
/// </summary>
/// <remarks>
/// The &lt;html&gt; tag is the container for all other HTML elements in a document.
/// This class inherits from <see cref="DoubleTagWithChildren"/> to allow child elements.
/// </remarks>
public class Html() : DoubleTagWithChildren("html");
