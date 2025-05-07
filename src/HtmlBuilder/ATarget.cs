namespace HtmlBuilder;

/// <summary>
/// Specifies where to open the linked document when the anchor (&lt;a&gt;) element is clicked.
/// </summary>
public enum ATarget
{
    /// <summary>
    /// Opens the link in the same frame or tab. (default)
    /// </summary>
    Self,

    /// <summary>
    /// Opens the link in a new tab or window.
    /// </summary>
    Blank,

    /// <summary>
    /// Opens the link in the parent frame.
    /// </summary>
    Parent,

    /// <summary>
    /// Opens the link in the full body of the window, exiting all frames.
    /// </summary>
    Top,

    /// <summary>
    /// Opens the link in a named frame.
    /// </summary>
    Named
}
