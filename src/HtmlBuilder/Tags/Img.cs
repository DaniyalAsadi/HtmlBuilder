namespace HtmlBuilder.Tags;

/// <summary>
/// Represents an HTML &lt;img&gt; tag.
/// </summary>
/// <remarks>
/// The &lt;img&gt; tag is used to embed images in an HTML document.
/// This class inherits from <see cref="SingleTag"/> as it is a self-closing tag.
/// </remarks>
public class Img() : SingleTag("img");