namespace HtmlBuilder.Enums;

public enum BaseTarget
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
