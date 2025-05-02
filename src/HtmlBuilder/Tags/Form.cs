namespace HtmlBuilder.Tags;

/// <summary>
/// Represents an HTML &lt;form&gt; tag.
/// </summary>
/// <remarks>
/// The &lt;form&gt; tag is used to create an HTML form for user input.
/// This class inherits from <see cref="DoubleTagWithChildren"/> to allow child elements.
/// </remarks>
public class Form() : DoubleTagWithChildren("form");