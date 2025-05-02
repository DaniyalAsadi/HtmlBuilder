namespace HtmlBuilder.Tags;

/// <summary>
/// Represents an HTML &lt;main&gt; element.
/// </summary>
/// <remarks>
/// The &lt;main&gt; element specifies the main content of an HTML document.
/// This class inherits from <see cref="DoubleTagWithChildren"/> to allow child elements.
/// </remarks>
public class Main() : DoubleTagWithChildren("main");