namespace HtmlBuilder.Enums;

/// <summary>
/// Specifies where to open the response when the form is submitted.
/// </summary>
public enum FormTarget
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
    Top
}
