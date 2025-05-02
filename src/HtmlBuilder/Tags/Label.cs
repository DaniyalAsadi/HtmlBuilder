namespace HtmlBuilder.Tags;

/// <summary>
/// Represents an HTML &lt;label&gt; element.
/// </summary>
/// <remarks>
/// The &lt;label&gt; element is used to define a label for an &lt;input&gt; element in HTML.
/// This class inherits from <see cref="DoubleTagWithContent"/> to allow content within the label tag.
/// </remarks>
public class Label() : DoubleTagWithContent("label");
